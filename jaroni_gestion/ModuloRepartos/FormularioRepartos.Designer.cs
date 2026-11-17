namespace jaroni_gestion.Formularios;

partial class FormularioRepartos
{
    private System.ComponentModel.IContainer components = null;
    private Label etiquetaTitulo;
    private Label etiquetaCodigo;
    private TextBox cajaTextoCodigo;
    private Label etiquetaDestinatario;
    private TextBox cajaTextoDestinatario;
    private Label etiquetaDireccion;
    private TextBox cajaTextoDireccion;
    private Button botonAgregarReparto;
    private Button botonEliminarReparto;
    private Button botonMostrarRepartos;
    private Button botonSiguienteParada;
    private Label etiquetaParadaActual;
    private ListBox listaVisualRepartos;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        etiquetaTitulo = new Label();
        etiquetaCodigo = new Label();
        cajaTextoCodigo = new TextBox();
        etiquetaDestinatario = new Label();
        cajaTextoDestinatario = new TextBox();
        etiquetaDireccion = new Label();
        cajaTextoDireccion = new TextBox();
        botonAgregarReparto = new Button();
        botonEliminarReparto = new Button();
        botonMostrarRepartos = new Button();
        botonSiguienteParada = new Button();
        etiquetaParadaActual = new Label();
        listaVisualRepartos = new ListBox();
        SuspendLayout();
        etiquetaTitulo.Location = new Point(20, 15);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new Size(300, 24);
        etiquetaTitulo.Text = "Turnos de Reparto";
        Controls.Add(etiquetaTitulo);
        etiquetaCodigo.Location = new Point(20, 50);
        etiquetaCodigo.Name = "etiquetaCodigo";
        etiquetaCodigo.Size = new Size(90, 23);
        etiquetaCodigo.Text = "Código";
        Controls.Add(etiquetaCodigo);
        cajaTextoCodigo.Location = new Point(120, 50);
        cajaTextoCodigo.Name = "cajaTextoCodigo";
        cajaTextoCodigo.Size = new Size(180, 23);
        Controls.Add(cajaTextoCodigo);
        etiquetaDestinatario.Location = new Point(20, 80);
        etiquetaDestinatario.Name = "etiquetaDestinatario";
        etiquetaDestinatario.Size = new Size(90, 23);
        etiquetaDestinatario.Text = "Destinatario";
        Controls.Add(etiquetaDestinatario);
        cajaTextoDestinatario.Location = new Point(120, 80);
        cajaTextoDestinatario.Name = "cajaTextoDestinatario";
        cajaTextoDestinatario.Size = new Size(250, 23);
        Controls.Add(cajaTextoDestinatario);
        etiquetaDireccion.Location = new Point(20, 110);
        etiquetaDireccion.Name = "etiquetaDireccion";
        etiquetaDireccion.Size = new Size(90, 23);
        etiquetaDireccion.Text = "Dirección";
        Controls.Add(etiquetaDireccion);
        cajaTextoDireccion.Location = new Point(120, 110);
        cajaTextoDireccion.Name = "cajaTextoDireccion";
        cajaTextoDireccion.Size = new Size(250, 23);
        Controls.Add(cajaTextoDireccion);
        botonAgregarReparto.Location = new Point(20, 150);
        botonAgregarReparto.Name = "botonAgregarReparto";
        botonAgregarReparto.Size = new Size(100, 30);
        botonAgregarReparto.Text = "Agregar";
        botonAgregarReparto.Click += botonAgregarReparto_Click;
        Controls.Add(botonAgregarReparto);
        botonEliminarReparto.Location = new Point(130, 150);
        botonEliminarReparto.Name = "botonEliminarReparto";
        botonEliminarReparto.Size = new Size(100, 30);
        botonEliminarReparto.Text = "Eliminar";
        botonEliminarReparto.Click += botonEliminarReparto_Click;
        Controls.Add(botonEliminarReparto);
        botonMostrarRepartos.Location = new Point(240, 150);
        botonMostrarRepartos.Name = "botonMostrarRepartos";
        botonMostrarRepartos.Size = new Size(100, 30);
        botonMostrarRepartos.Text = "Mostrar";
        botonMostrarRepartos.Click += botonMostrarRepartos_Click;
        Controls.Add(botonMostrarRepartos);
        botonSiguienteParada.Location = new Point(350, 150);
        botonSiguienteParada.Name = "botonSiguienteParada";
        botonSiguienteParada.Size = new Size(130, 30);
        botonSiguienteParada.Text = "Siguiente parada";
        botonSiguienteParada.Click += botonSiguienteParada_Click;
        Controls.Add(botonSiguienteParada);
        etiquetaParadaActual.Location = new Point(20, 195);
        etiquetaParadaActual.Name = "etiquetaParadaActual";
        etiquetaParadaActual.Size = new Size(560, 40);
        etiquetaParadaActual.Text = "Parada actual: ninguna";
        Controls.Add(etiquetaParadaActual);
        listaVisualRepartos.Location = new Point(20, 240);
        listaVisualRepartos.Name = "listaVisualRepartos";
        listaVisualRepartos.Size = new Size(560, 160);
        Controls.Add(listaVisualRepartos);
        ClientSize = new Size(600, 450);
        Name = "FormularioRepartos";
        Text = "Turnos de Reparto";
        ResumeLayout(false);
        PerformLayout();
    }
}
