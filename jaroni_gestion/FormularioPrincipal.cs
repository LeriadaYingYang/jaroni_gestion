using jaroni_gestion.Formularios;

namespace jaroni_gestion;

public partial class FormularioPrincipal : Form
{
    public FormularioPrincipal()
    {
        InitializeComponent();
    }

    private void MostrarFormularioEnPanel(Form formulario)
    {
        while (panelContenidoPrincipal.Controls.Count > 0)
        {
            Control control = panelContenidoPrincipal.Controls[0];
            panelContenidoPrincipal.Controls.Remove(control);
            control.Dispose();
        }

        formulario.TopLevel = false;
        formulario.FormBorderStyle = FormBorderStyle.None;
        formulario.Dock = DockStyle.Fill;
        panelContenidoPrincipal.Controls.Add(formulario);
        formulario.Show();
    }

    private void botonInicio_Click(object sender, EventArgs e)
    {
        while (panelContenidoPrincipal.Controls.Count > 0)
        {
            Control control = panelContenidoPrincipal.Controls[0];
            panelContenidoPrincipal.Controls.Remove(control);
            control.Dispose();
        }
    }

    private void botonInventario_Click(object sender, EventArgs e)
    {
        MostrarFormularioEnPanel(new FormularioInventario());
    }

    private void botonCotizaciones_Click(object sender, EventArgs e)
    {
        MostrarFormularioEnPanel(new FormularioCotizaciones());
    }

    private void botonRepartos_Click(object sender, EventArgs e)
    {
        MostrarFormularioEnPanel(new FormularioRepartos());
    }

    private void botonVentas_Click(object sender, EventArgs e)
    {
        MostrarFormularioEnPanel(new FormularioVentas());
    }

    private void botonPedidos_Click(object sender, EventArgs e)
    {
        MostrarFormularioEnPanel(new FormularioPedidos());
    }

    private void botonClientes_Click(object sender, EventArgs e)
    {
        MostrarFormularioEnPanel(new FormularioClientes());
    }

    private void botonRedDistribucion_Click(object sender, EventArgs e)
    {
        MostrarFormularioEnPanel(new FormularioRedDistribucion());
    }

    private void botonSalir_Click(object sender, EventArgs e)
    {
        Close();
    }
}
