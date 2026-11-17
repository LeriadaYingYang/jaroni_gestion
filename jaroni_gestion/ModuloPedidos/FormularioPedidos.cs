using jaroni_gestion.Datos;

namespace jaroni_gestion.Formularios;

public partial class FormularioPedidos : Form
{
    public FormularioPedidos()
    {
        InitializeComponent();
        CargarClientesYProductos();
        MostrarPedidos();
    }

    private void MostrarPedidos()
    {
        listaVisualPedidos.Items.Clear();
        List<Pedido> pedidos = MemoriaTemporal.Pedidos.ObtenerTodos();
        foreach (Pedido pedido in pedidos)
            listaVisualPedidos.Items.Add("Turno: " + pedido.NumeroTurno + " - " + pedido.NombreCliente + " - " + pedido.Descripcion);
    }

    private void CargarClientesYProductos()
    {
        foreach (Cliente cliente in MemoriaTemporal.Clientes.Inorden())
            listaDesplegableClientes.Items.Add(cliente);
        foreach (Producto producto in MemoriaTemporal.Productos.ObtenerTodos())
            listaDesplegableProductos.Items.Add(producto);
    }

    private void botonRegistrarPedido_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoNumeroTurno.Text, out int numeroTurno))
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
        Pedido pedido = new Pedido();
        pedido.NumeroTurno = numeroTurno;
        pedido.CodigoCliente = cliente.Codigo;
        pedido.NombreCliente = cliente.Nombre;
        pedido.CodigoProducto = producto!.Codigo;
        pedido.NombreProducto = producto.Nombre;
        pedido.Cantidad = cantidad;
        pedido.Descripcion = producto.Nombre + " - Cantidad: " + cantidad;
        MemoriaTemporal.Pedidos.Encolar(pedido);
        MostrarPedidos();
    }

    private void botonAtenderPedido_Click(object sender, EventArgs e)
    {
        if (MemoriaTemporal.Pedidos.EstaVacia)
        {
            MessageBox.Show("No hay pedidos para atender.");
            return;
        }
        Pedido pedido = MemoriaTemporal.Pedidos.Desencolar();
        MemoriaTemporal.PedidoAtendido = pedido;
        MostrarPedidos();
        MessageBox.Show("Pedido atendido: turno " + pedido.NumeroTurno + " - " + pedido.NombreCliente + " - " + pedido.Descripcion);
    }

    private void botonVerPrimerPedido_Click(object sender, EventArgs e)
    {
        if (MemoriaTemporal.Pedidos.EstaVacia)
        {
            MessageBox.Show("No hay pedidos registrados.");
            return;
        }
        Pedido pedido = MemoriaTemporal.Pedidos.VerFrente();
        MessageBox.Show("Primer pedido: turno " + pedido.NumeroTurno + " - " + pedido.NombreCliente + " - " + pedido.Descripcion);
    }

    private void botonMostrarPedidos_Click(object sender, EventArgs e)
    {
        MostrarPedidos();
    }

    private void botonLimpiarPedidos_Click(object sender, EventArgs e)
    {
        MemoriaTemporal.Pedidos.Limpiar();
        MostrarPedidos();
    }
}
