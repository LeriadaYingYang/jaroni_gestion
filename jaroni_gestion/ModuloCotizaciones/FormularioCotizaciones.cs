using jaroni_gestion.Datos;
using jaroni_gestion.Estructuras;

namespace jaroni_gestion.Formularios;

public partial class FormularioCotizaciones : Form
{
    private NodoCotizacion? nodoActual;

    public FormularioCotizaciones()
    {
        InitializeComponent();
        CargarClientesYProductos();
        nodoActual = MemoriaTemporal.Cotizaciones.ObtenerCabeza();
        MostrarCotizacionActual();
    }

    private void MostrarCotizacionActual()
    {
        if (nodoActual == null)
        {
            etiquetaCotizacionActual.Text = "Cotización actual: ninguna";
            return;
        }
        Cotizacion cotizacion = nodoActual.Cotizacion;
        etiquetaCotizacionActual.Text = "Número: " + cotizacion.Numero +
            "\nCliente: " + cotizacion.NombreCliente +
            "\nProducto: " + cotizacion.NombreProducto +
            "\nCantidad: " + cotizacion.Cantidad +
            "\nPrecio: " + cotizacion.Precio +
            "\nTotal: " + cotizacion.Total;
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
        etiquetaPrecioSeleccionado.Text = producto == null ? "Precio: -" : "Precio: " + producto.Precio;
        etiquetaTotal.Text = "Total: -";
        if (producto != null && int.TryParse(cajaTextoCantidad.Text, out int cantidad) && cantidad > 0)
        {
            try
            {
                etiquetaTotal.Text = "Total: " + (cantidad * producto.Precio);
            }
            catch (OverflowException)
            {
                etiquetaTotal.Text = "Total: fuera de rango";
            }
        }
    }

    private void botonUsarPedidoAtendido_Click(object sender, EventArgs e)
    {
        Pedido? pedido = MemoriaTemporal.PedidoAtendido;
        if (pedido == null)
        {
            MessageBox.Show("No hay un pedido atendido.");
            return;
        }
        Cliente? cliente = MemoriaTemporal.Clientes.Buscar(pedido.CodigoCliente);
        int indiceProducto = MemoriaTemporal.Productos.Buscar(pedido.CodigoProducto);
        if (cliente == null || indiceProducto < 0)
        {
            MessageBox.Show("El cliente o el producto ya no esta registrado.");
            return;
        }
        listaDesplegableClientes.SelectedItem = cliente;
        listaDesplegableProductos.SelectedItem = MemoriaTemporal.Productos.ObtenerTodos()[indiceProducto];
        cajaTextoCantidad.Text = pedido.Cantidad.ToString();
    }

    private void botonRegistrarCotizacion_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoNumero.Text, out int numero))
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
        Cotizacion cotizacion = new Cotizacion();
        cotizacion.Numero = numero;
        cotizacion.CodigoCliente = cliente.Codigo;
        cotizacion.NombreCliente = cliente.Nombre;
        cotizacion.CodigoProducto = producto!.Codigo;
        cotizacion.NombreProducto = producto.Nombre;
        cotizacion.Cantidad = cantidad;
        cotizacion.Precio = producto.Precio;
        try
        {
            decimal total = cotizacion.Total;
        }
        catch (OverflowException)
        {
            MessageBox.Show("El total es demasiado grande.");
            return;
        }
        MemoriaTemporal.Cotizaciones.AgregarFinal(cotizacion);
        nodoActual = MemoriaTemporal.Cotizaciones.ObtenerCola();
        MostrarCotizacionActual();
    }

    private void botonConsultarCotizacion_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoNumero.Text, out int numero))
        {
            MessageBox.Show("Ingrese un número válido para consultar.");
            return;
        }
        NodoCotizacion? nodoEncontrado = MemoriaTemporal.Cotizaciones.Buscar(numero);
        if (nodoEncontrado == null)
        {
            MessageBox.Show("Cotización no encontrada.");
            return;
        }
        nodoActual = nodoEncontrado;
        MostrarCotizacionActual();
    }

    private void botonEliminarCotizacion_Click(object sender, EventArgs e)
    {
        if (nodoActual == null)
        {
            MessageBox.Show("No hay una cotización para eliminar.");
            return;
        }
        NodoCotizacion nodoEliminar = nodoActual;
        nodoActual = nodoEliminar.Siguiente ?? nodoEliminar.Anterior;
        MemoriaTemporal.Cotizaciones.Eliminar(nodoEliminar);
        MostrarCotizacionActual();
    }

    private void botonAnterior_Click(object sender, EventArgs e)
    {
        if (nodoActual == null || nodoActual.Anterior == null)
        {
            MessageBox.Show("No hay una cotización anterior.");
            return;
        }
        nodoActual = nodoActual.Anterior;
        MostrarCotizacionActual();
    }

    private void botonSiguiente_Click(object sender, EventArgs e)
    {
        if (nodoActual == null || nodoActual.Siguiente == null)
        {
            MessageBox.Show("No hay una cotización siguiente.");
            return;
        }
        nodoActual = nodoActual.Siguiente;
        MostrarCotizacionActual();
    }
}
