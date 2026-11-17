namespace jaroni_gestion.Formularios;

partial class FormularioVentas
{
    private System.ComponentModel.IContainer components = null;
    private Label etiquetaTitulo;
    private Label etiquetaCodigo;
    private TextBox cajaTextoCodigo;
    private Label etiquetaProducto;
    private TextBox cajaTextoProducto;
    private Label etiquetaCantidad;
    private TextBox cajaTextoCantidad;
    private Label etiquetaPrecio;
    private TextBox cajaTextoPrecio;
    private Button botonRegistrarVenta;
    private Button botonDeshacerVenta;
    private Button botonConsultarCima;
    private Button botonMostrarVentas;
    private Button botonLimpiarVentas;
    private Label etiquetaListaVentas;
    private ListBox listaVisualVentas;

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
        etiquetaProducto = new Label();
        cajaTextoProducto = new TextBox();
        etiquetaCantidad = new Label();
        cajaTextoCantidad = new TextBox();
        etiquetaPrecio = new Label();
        cajaTextoPrecio = new TextBox();
        botonRegistrarVenta = new Button();
        botonDeshacerVenta = new Button();
        botonConsultarCima = new Button();
        botonMostrarVentas = new Button();
        botonLimpiarVentas = new Button();
        etiquetaListaVentas = new Label();
        listaVisualVentas = new ListBox();
        SuspendLayout();
        etiquetaTitulo.Location = new Point(20, 10);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new Size(300, 24);
        etiquetaTitulo.Text = "Registro de Ventas";
        Controls.Add(etiquetaTitulo);
        etiquetaCodigo.Location = new Point(20, 40);
        etiquetaCodigo.Name = "etiquetaCodigo";
        etiquetaCodigo.Size = new Size(80, 23);
        etiquetaCodigo.Text = "Código";
        Controls.Add(etiquetaCodigo);
        cajaTextoCodigo.Location = new Point(105, 40);
        cajaTextoCodigo.Name = "cajaTextoCodigo";
        cajaTextoCodigo.Size = new Size(150, 23);
        Controls.Add(cajaTextoCodigo);
        etiquetaProducto.Location = new Point(20, 70);
        etiquetaProducto.Name = "etiquetaProducto";
        etiquetaProducto.Size = new Size(80, 23);
        etiquetaProducto.Text = "Producto";
        Controls.Add(etiquetaProducto);
        cajaTextoProducto.Location = new Point(105, 70);
        cajaTextoProducto.Name = "cajaTextoProducto";
        cajaTextoProducto.Size = new Size(150, 23);
        Controls.Add(cajaTextoProducto);
        etiquetaCantidad.Location = new Point(280, 40);
        etiquetaCantidad.Name = "etiquetaCantidad";
        etiquetaCantidad.Size = new Size(70, 23);
        etiquetaCantidad.Text = "Cantidad";
        Controls.Add(etiquetaCantidad);
        cajaTextoCantidad.Location = new Point(355, 40);
        cajaTextoCantidad.Name = "cajaTextoCantidad";
        cajaTextoCantidad.Size = new Size(150, 23);
        Controls.Add(cajaTextoCantidad);
        etiquetaPrecio.Location = new Point(280, 70);
        etiquetaPrecio.Name = "etiquetaPrecio";
        etiquetaPrecio.Size = new Size(70, 23);
        etiquetaPrecio.Text = "Precio";
        Controls.Add(etiquetaPrecio);
        cajaTextoPrecio.Location = new Point(355, 70);
        cajaTextoPrecio.Name = "cajaTextoPrecio";
        cajaTextoPrecio.Size = new Size(150, 23);
        Controls.Add(cajaTextoPrecio);
        botonRegistrarVenta.Location = new Point(20, 105);
        botonRegistrarVenta.Name = "botonRegistrarVenta";
        botonRegistrarVenta.Size = new Size(100, 30);
        botonRegistrarVenta.Text = "Registrar";
        botonRegistrarVenta.Click += botonRegistrarVenta_Click;
        Controls.Add(botonRegistrarVenta);
        botonDeshacerVenta.Location = new Point(130, 105);
        botonDeshacerVenta.Name = "botonDeshacerVenta";
        botonDeshacerVenta.Size = new Size(100, 30);
        botonDeshacerVenta.Text = "Deshacer";
        botonDeshacerVenta.Click += botonDeshacerVenta_Click;
        Controls.Add(botonDeshacerVenta);
        botonConsultarCima.Location = new Point(240, 105);
        botonConsultarCima.Name = "botonConsultarCima";
        botonConsultarCima.Size = new Size(100, 30);
        botonConsultarCima.Text = "Ver cima";
        botonConsultarCima.Click += botonConsultarCima_Click;
        Controls.Add(botonConsultarCima);
        botonMostrarVentas.Location = new Point(350, 105);
        botonMostrarVentas.Name = "botonMostrarVentas";
        botonMostrarVentas.Size = new Size(100, 30);
        botonMostrarVentas.Text = "Mostrar";
        botonMostrarVentas.Click += botonMostrarVentas_Click;
        Controls.Add(botonMostrarVentas);
        botonLimpiarVentas.Location = new Point(460, 105);
        botonLimpiarVentas.Name = "botonLimpiarVentas";
        botonLimpiarVentas.Size = new Size(100, 30);
        botonLimpiarVentas.Text = "Limpiar";
        botonLimpiarVentas.Click += botonLimpiarVentas_Click;
        Controls.Add(botonLimpiarVentas);
        etiquetaListaVentas.Location = new Point(20, 140);
        etiquetaListaVentas.Name = "etiquetaListaVentas";
        etiquetaListaVentas.Size = new Size(250, 23);
        etiquetaListaVentas.Text = "Ventas desde la cima:";
        Controls.Add(etiquetaListaVentas);
        listaVisualVentas.Location = new Point(20, 165);
        listaVisualVentas.Name = "listaVisualVentas";
        listaVisualVentas.Size = new Size(560, 190);
        Controls.Add(listaVisualVentas);
        ClientSize = new Size(600, 450);
        Name = "FormularioVentas";
        Text = "Registro de Ventas";
        ResumeLayout(false);
        PerformLayout();
    }
}
