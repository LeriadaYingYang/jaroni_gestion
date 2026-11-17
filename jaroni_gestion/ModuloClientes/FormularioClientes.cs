using jaroni_gestion.Datos;

namespace jaroni_gestion.Formularios;

public partial class FormularioClientes : Form
{
    public FormularioClientes()
    {
        InitializeComponent();
        listaVisualClientes.Items.Clear();
        etiquetaRecorrido.Text = "Seleccione un recorrido.";
    }

    private void MostrarClientes(List<Cliente> clientes, string recorrido)
    {
        etiquetaRecorrido.Text = "Recorrido: " + recorrido;
        listaVisualClientes.Items.Clear();
        foreach (Cliente cliente in clientes)
            listaVisualClientes.Items.Add(cliente.Codigo + " - " + cliente.Nombre + " - " + cliente.Telefono + " - " + cliente.TipoCliente);
    }

    private void botonAgregarCliente_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoCodigo.Text, out int codigo))
        {
            MessageBox.Show("Ingrese un código válido.");
            return;
        }
        string nombre = cajaTextoNombre.Text.Trim();
        string telefono = cajaTextoTelefono.Text.Trim();
        string tipoCliente = cajaTextoTipoCliente.Text.Trim();
        if (nombre.Length == 0 || telefono.Length == 0 || tipoCliente.Length == 0)
        {
            MessageBox.Show("Ingrese el nombre, teléfono y tipo de cliente.");
            return;
        }
        Cliente cliente = new Cliente();
        cliente.Codigo = codigo;
        cliente.Nombre = nombre;
        cliente.Direccion = cajaTextoDireccion.Text.Trim();
        cliente.Telefono = telefono;
        cliente.TipoCliente = tipoCliente;
        if (!MemoriaTemporal.Clientes.Insertar(cliente))
        {
            MessageBox.Show("Ya existe un cliente con ese código.");
            return;
        }
        listaVisualClientes.Items.Clear();
        etiquetaRecorrido.Text = "Seleccione un recorrido.";
    }

    private void botonBuscarCliente_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoCodigo.Text, out int codigo))
        {
            MessageBox.Show("Ingrese un código válido.");
            return;
        }
        Cliente? cliente = MemoriaTemporal.Clientes.Buscar(codigo);
        if (cliente == null)
        {
            MessageBox.Show("Cliente no encontrado.");
            return;
        }
        cajaTextoNombre.Text = cliente.Nombre;
        cajaTextoDireccion.Text = cliente.Direccion;
        cajaTextoTelefono.Text = cliente.Telefono;
        cajaTextoTipoCliente.Text = cliente.TipoCliente;
    }

    private void botonGuardarDireccion_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoCodigo.Text, out int codigo))
        {
            MessageBox.Show("Ingrese un codigo valido.");
            return;
        }
        Cliente? cliente = MemoriaTemporal.Clientes.Buscar(codigo);
        if (cliente == null)
        {
            MessageBox.Show("Cliente no encontrado.");
            return;
        }
        cliente.Direccion = cajaTextoDireccion.Text.Trim();
    }

    private void botonEliminarCliente_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoCodigo.Text, out int codigo))
        {
            MessageBox.Show("Ingrese un código válido.");
            return;
        }
        if (!MemoriaTemporal.Clientes.Eliminar(codigo))
        {
            MessageBox.Show("Cliente no encontrado.");
            return;
        }
        listaVisualClientes.Items.Clear();
        etiquetaRecorrido.Text = "Seleccione un recorrido.";
    }

    private void botonPreorden_Click(object sender, EventArgs e)
    {
        MostrarClientes(MemoriaTemporal.Clientes.Preorden(), "Preorden");
    }

    private void botonInorden_Click(object sender, EventArgs e)
    {
        MostrarClientes(MemoriaTemporal.Clientes.Inorden(), "Inorden");
    }

    private void botonPostorden_Click(object sender, EventArgs e)
    {
        MostrarClientes(MemoriaTemporal.Clientes.Postorden(), "Postorden");
    }
}
