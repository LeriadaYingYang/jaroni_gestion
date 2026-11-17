using jaroni_gestion.Datos;

namespace jaroni_gestion.Formularios;

public partial class FormularioPedidos : Form
{
    public FormularioPedidos()
    {
        InitializeComponent();
        MostrarPedidos();
    }

    private void MostrarPedidos()
    {
        listaVisualPedidos.Items.Clear();
        List<Pedido> pedidos = MemoriaTemporal.Pedidos.ObtenerTodos();
        foreach (Pedido pedido in pedidos)
            listaVisualPedidos.Items.Add("Turno: " + pedido.NumeroTurno + " - " + pedido.NombreCliente + " - " + pedido.Descripcion);
    }

    private void botonRegistrarPedido_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoNumeroTurno.Text, out int numeroTurno))
        {
            MessageBox.Show("Ingrese un número de turno válido.");
            return;
        }
        string nombreCliente = cajaTextoNombreCliente.Text.Trim();
        string descripcion = cajaTextoDescripcion.Text.Trim();
        if (nombreCliente.Length == 0 || descripcion.Length == 0)
        {
            MessageBox.Show("Ingrese el nombre del cliente y la descripción.");
            return;
        }
        Pedido pedido = new Pedido();
        pedido.NumeroTurno = numeroTurno;
        pedido.NombreCliente = nombreCliente;
        pedido.Descripcion = descripcion;
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
