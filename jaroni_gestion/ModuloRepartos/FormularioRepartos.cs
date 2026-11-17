using jaroni_gestion.Datos;

namespace jaroni_gestion.Formularios;

public partial class FormularioRepartos : Form
{
    public FormularioRepartos()
    {
        InitializeComponent();
        MostrarRepartos();
    }

    private void MostrarRepartos()
    {
        listaVisualRepartos.Items.Clear();
        List<Reparto> repartos = MemoriaTemporal.Repartos.ObtenerTodos();
        foreach (Reparto reparto in repartos)
            listaVisualRepartos.Items.Add(reparto.Codigo + " - " + reparto.Destinatario + " - " + reparto.Direccion);

        Reparto? paradaActual = MemoriaTemporal.Repartos.ParadaActual;
        if (paradaActual == null)
            etiquetaParadaActual.Text = "Parada actual: ninguna";
        else
            etiquetaParadaActual.Text = "Parada actual: " + paradaActual.Codigo + " - " + paradaActual.Destinatario + " - " + paradaActual.Direccion;
    }

    private void botonAgregarReparto_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoCodigo.Text, out int codigo))
        {
            MessageBox.Show("Ingrese un código válido.");
            return;
        }
        string destinatario = cajaTextoDestinatario.Text.Trim();
        string direccion = cajaTextoDireccion.Text.Trim();
        if (destinatario.Length == 0 || direccion.Length == 0)
        {
            MessageBox.Show("Ingrese el destinatario y la dirección.");
            return;
        }
        Reparto reparto = new Reparto();
        reparto.Codigo = codigo;
        reparto.Destinatario = destinatario;
        reparto.Direccion = direccion;
        MemoriaTemporal.Repartos.Agregar(reparto);
        MostrarRepartos();
    }

    private void botonEliminarReparto_Click(object sender, EventArgs e)
    {
        int indice = listaVisualRepartos.SelectedIndex;
        if (indice < 0)
        {
            MessageBox.Show("Seleccione una parada para eliminar.");
            return;
        }
        MemoriaTemporal.Repartos.Eliminar(indice);
        MostrarRepartos();
    }

    private void botonMostrarRepartos_Click(object sender, EventArgs e)
    {
        MostrarRepartos();
    }

    private void botonSiguienteParada_Click(object sender, EventArgs e)
    {
        if (MemoriaTemporal.Repartos.ParadaActual == null)
        {
            MessageBox.Show("No hay paradas de reparto.");
            return;
        }
        MemoriaTemporal.Repartos.Avanzar();
        MostrarRepartos();
    }
}
