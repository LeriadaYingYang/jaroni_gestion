using jaroni_gestion.Datos;
using jaroni_gestion.Estructuras;

namespace jaroni_gestion.Formularios;

public partial class FormularioVentas : Form
{
    private decimal? precioCotizacion;
    private Producto? productoCotizado;
    private Cliente? clienteCotizado;
    public FormularioVentas()
    {
        InitializeComponent();
        CargarClientesYProductos();
        MostrarVentas();
    }

    private void MostrarVentas()
    {
        listaVisualVentas.Items.Clear();
        List<Venta> ventas = MemoriaTemporal.Ventas.ObtenerTodos();
        foreach (Venta venta in ventas)
            listaVisualVentas.Items.Add(venta.Codigo + " - " + venta.NombreCliente + " - " + venta.NombreProducto + " - Cantidad: " + venta.Cantidad + " - Precio: " + venta.Precio + " - Total: " + venta.Total);
    }

    private void CargarClientesYProductos()
    {
        foreach (Cliente cliente in MemoriaTemporal.Clientes.Inorden())
            listaDesplegableClientes.Items.Add(cliente);
        foreach (Producto producto in MemoriaTemporal.Productos.ObtenerTodos())
            listaDesplegableProductos.Items.Add(producto);
    }

    private void botonCalcular_Click(object sender, EventArgs e)
    {
        Producto? producto = listaDesplegableProductos.SelectedItem as Producto;
        Cliente? cliente = listaDesplegableClientes.SelectedItem as Cliente;
        decimal precio = producto != null && producto == productoCotizado && cliente == clienteCotizado && precioCotizacion.HasValue
            ? precioCotizacion.Value : (producto == null ? 0 : producto.Precio);
        etiquetaPrecioSeleccionado.Text = producto == null ? "Precio: -" : "Precio: " + precio;
        etiquetaTotal.Text = "Total: -";
        if (producto != null && int.TryParse(cajaTextoCantidad.Text, out int cantidad) && cantidad > 0)
        {
            try
            {
                etiquetaTotal.Text = "Total: " + (cantidad * precio);
            }
            catch (OverflowException)
            {
                etiquetaTotal.Text = "Total: fuera de rango";
            }
        }
    }

    private void botonRegistrarVenta_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoCodigo.Text, out int codigo))
        {
            MessageBox.Show("Ingrese un número válido.");
            return;
        }
        Cliente? cliente = listaDesplegableClientes.SelectedItem as Cliente;
        Producto? producto = listaDesplegableProductos.SelectedItem as Producto;
        if (cliente == null || MemoriaTemporal.Clientes.Buscar(cliente.Codigo) != cliente)
        {
            MessageBox.Show("Seleccione un cliente registrado.");
            return;
        }
        int indiceProducto = producto == null ? -1 : MemoriaTemporal.Productos.Buscar(producto.Codigo);
        if (indiceProducto < 0 || MemoriaTemporal.Productos.ObtenerTodos()[indiceProducto] != producto)
        {
            MessageBox.Show("Seleccione un producto registrado.");
            return;
        }
        if (!int.TryParse(cajaTextoCantidad.Text, out int cantidad) || cantidad <= 0)
        {
            MessageBox.Show("Ingrese una cantidad válida y positiva.");
            return;
        }
        if (cantidad > producto!.Cantidad)
        {
            MessageBox.Show("No hay suficiente stock.");
            return;
        }
        Venta venta = new Venta();
        venta.Codigo = codigo;
        venta.CodigoCliente = cliente.Codigo;
        venta.NombreCliente = cliente.Nombre;
        venta.DireccionCliente = cliente.Direccion;
        venta.CodigoProducto = producto!.Codigo;
        venta.NombreProducto = producto.Nombre;
        venta.Cantidad = cantidad;
        venta.Precio = producto == productoCotizado && cliente == clienteCotizado && precioCotizacion.HasValue
            ? precioCotizacion.Value : producto.Precio;
        try
        {
            decimal total = venta.Total;
        }
        catch (OverflowException)
        {
            MessageBox.Show("El total es demasiado grande.");
            return;
        }
        producto.Cantidad -= cantidad;
        MemoriaTemporal.Ventas.Apilar(venta);
        precioCotizacion = null;
        productoCotizado = null;
        clienteCotizado = null;
        etiquetaPrecioSeleccionado.Text = "Precio: -";
        etiquetaTotal.Text = "Total: -";
        MostrarVentas();
    }

    private void botonDeshacerVenta_Click(object sender, EventArgs e)
    {
        if (MemoriaTemporal.Ventas.EstaVacia)
        {
            MessageBox.Show("No hay ventas para deshacer.");
            return;
        }
        Venta venta = MemoriaTemporal.Ventas.VerCima();
        int indiceProducto = MemoriaTemporal.Productos.Buscar(venta.CodigoProducto);
        if (indiceProducto < 0)
        {
            MessageBox.Show("No se encontro el producto en el inventario.");
            return;
        }
        Producto producto = MemoriaTemporal.Productos.ObtenerTodos()[indiceProducto];
        if (producto.Cantidad > int.MaxValue - venta.Cantidad)
        {
            MessageBox.Show("La cantidad del inventario excederia el limite permitido.");
            return;
        }
        MemoriaTemporal.Ventas.Desapilar();
        producto.Cantidad += venta.Cantidad;
        MostrarVentas();
    }

    private void botonRecuperarCotizacion_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoNumeroCotizacion.Text, out int numero))
        {
            MessageBox.Show("Ingrese el numero de la cotizacion.");
            return;
        }
        NodoCotizacion? nodoCotizacion = MemoriaTemporal.Cotizaciones.Buscar(numero);
        if (nodoCotizacion == null)
        {
            MessageBox.Show("Cotizacion no encontrada.");
            return;
        }
        Cotizacion cotizacion = nodoCotizacion.Cotizacion;
        Cliente? cliente = MemoriaTemporal.Clientes.Buscar(cotizacion.CodigoCliente);
        int indiceProducto = MemoriaTemporal.Productos.Buscar(cotizacion.CodigoProducto);
        if (cliente == null || indiceProducto < 0)
        {
            MessageBox.Show("El cliente o el producto ya no esta registrado.");
            return;
        }
        Producto producto = MemoriaTemporal.Productos.ObtenerTodos()[indiceProducto];
        listaDesplegableClientes.SelectedItem = cliente;
        listaDesplegableProductos.SelectedItem = producto;
        cajaTextoCantidad.Text = cotizacion.Cantidad.ToString();
        precioCotizacion = cotizacion.Precio;
        productoCotizado = producto;
        clienteCotizado = cliente;
        botonCalcular_Click(sender, e);
    }

    private void botonAgregarEntrega_Click(object sender, EventArgs e)
    {
        int indice = listaVisualVentas.SelectedIndex;
        List<Venta> ventas = MemoriaTemporal.Ventas.ObtenerTodos();
        if (indice < 0 || indice >= ventas.Count)
        {
            MessageBox.Show("Seleccione una venta para la entrega.");
            return;
        }
        Venta venta = ventas[indice];
        if (string.IsNullOrWhiteSpace(venta.DireccionCliente))
        {
            Cliente? cliente = MemoriaTemporal.Clientes.Buscar(venta.CodigoCliente);
            if (cliente == null || string.IsNullOrWhiteSpace(cliente.Direccion))
            {
                MessageBox.Show("Registre la direccion del cliente antes de agregar la entrega.");
                return;
            }
            venta.DireccionCliente = cliente.Direccion;
        }
        foreach (Reparto repartoRegistrado in MemoriaTemporal.Repartos.ObtenerTodos())
        {
            if (repartoRegistrado.VentaOrigen == venta)
            {
                MessageBox.Show("Esta venta ya tiene una parada de reparto.");
                return;
            }
        }
        Reparto reparto = new Reparto();
        reparto.Codigo = venta.Codigo;
        reparto.Destinatario = venta.NombreCliente;
        reparto.Direccion = venta.DireccionCliente;
        reparto.VentaOrigen = venta;
        MemoriaTemporal.Repartos.Agregar(reparto);
    }

    private void botonConsultarCima_Click(object sender, EventArgs e)
    {
        if (MemoriaTemporal.Ventas.EstaVacia)
        {
            MessageBox.Show("No hay ventas registradas.");
            return;
        }
        Venta venta = MemoriaTemporal.Ventas.VerCima();
        MessageBox.Show("Última venta: " + venta.Codigo + " - " + venta.NombreCliente + " - " + venta.NombreProducto + " - Total: " + venta.Total);
    }

    private void botonMostrarVentas_Click(object sender, EventArgs e)
    {
        MostrarVentas();
    }

    private void botonLimpiarVentas_Click(object sender, EventArgs e)
    {
        List<Venta> ventas = MemoriaTemporal.Ventas.ObtenerTodos();
        foreach (Venta venta in ventas)
        {
            int indiceProducto = MemoriaTemporal.Productos.Buscar(venta.CodigoProducto);
            if (indiceProducto < 0)
            {
                MessageBox.Show("No se encontro un producto necesario para devolver el stock.");
                return;
            }
            Producto producto = MemoriaTemporal.Productos.ObtenerTodos()[indiceProducto];
            long cantidadRestituir = 0;
            foreach (Venta ventaRegistrada in ventas)
            {
                if (ventaRegistrada.CodigoProducto == venta.CodigoProducto)
                    cantidadRestituir += ventaRegistrada.Cantidad;
            }
            if ((long)producto.Cantidad + cantidadRestituir > int.MaxValue)
            {
                MessageBox.Show("No se puede devolver el stock porque excede el limite permitido.");
                return;
            }
        }
        while (!MemoriaTemporal.Ventas.EstaVacia)
        {
            Venta venta = MemoriaTemporal.Ventas.Desapilar();
            int indiceProducto = MemoriaTemporal.Productos.Buscar(venta.CodigoProducto);
            Producto producto = MemoriaTemporal.Productos.ObtenerTodos()[indiceProducto];
            producto.Cantidad += venta.Cantidad;
        }
        MostrarVentas();
    }
}
