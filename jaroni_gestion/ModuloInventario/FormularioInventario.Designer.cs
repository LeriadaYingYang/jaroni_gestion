namespace jaroni_gestion.Formularios;

partial class FormularioInventario
{
    private System.ComponentModel.IContainer components = null;
    private Label etiquetaTitulo;
    private Label etiquetaCodigo;
    private TextBox cajaTextoCodigo;
    private Label etiquetaNombre;
    private TextBox cajaTextoNombre;
    private Label etiquetaPrecio;
    private TextBox cajaTextoPrecio;
    private Label etiquetaCantidad;
    private TextBox cajaTextoCantidad;
    private ListBox listaVisualProductos;
    private Button botonAgregarProducto;
    private Button botonBuscarProducto;
    private Button botonEliminarProducto;
    private Button botonMostrarProductos;
    private Button botonLimpiarProductos;

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
        etiquetaNombre = new Label();
        cajaTextoNombre = new TextBox();
        etiquetaPrecio = new Label();
        cajaTextoPrecio = new TextBox();
        etiquetaCantidad = new Label();
        cajaTextoCantidad = new TextBox();
        listaVisualProductos = new ListBox();
        botonAgregarProducto = new Button();
        botonBuscarProducto = new Button();
        botonEliminarProducto = new Button();
        botonMostrarProductos = new Button();
        botonLimpiarProductos = new Button();
        SuspendLayout();
        etiquetaTitulo.Location = new Point(20, 20);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new Size(300, 24);
        etiquetaTitulo.Text = "Inventario de Productos";
        Controls.Add(etiquetaTitulo);
        etiquetaCodigo.Location = new Point(20, 60);
        etiquetaCodigo.Name = "etiquetaCodigo";
        etiquetaCodigo.Size = new Size(80, 23);
        etiquetaCodigo.Text = "Código";
        Controls.Add(etiquetaCodigo);
        cajaTextoCodigo.Location = new Point(110, 60);
        cajaTextoCodigo.Name = "cajaTextoCodigo";
        cajaTextoCodigo.Size = new Size(160, 23);
        Controls.Add(cajaTextoCodigo);
        etiquetaNombre.Location = new Point(20, 90);
        etiquetaNombre.Name = "etiquetaNombre";
        etiquetaNombre.Size = new Size(80, 23);
        etiquetaNombre.Text = "Nombre";
        Controls.Add(etiquetaNombre);
        cajaTextoNombre.Location = new Point(110, 90);
        cajaTextoNombre.Name = "cajaTextoNombre";
        cajaTextoNombre.Size = new Size(160, 23);
        Controls.Add(cajaTextoNombre);
        etiquetaPrecio.Location = new Point(20, 120);
        etiquetaPrecio.Name = "etiquetaPrecio";
        etiquetaPrecio.Size = new Size(80, 23);
        etiquetaPrecio.Text = "Precio";
        Controls.Add(etiquetaPrecio);
        cajaTextoPrecio.Location = new Point(110, 120);
        cajaTextoPrecio.Name = "cajaTextoPrecio";
        cajaTextoPrecio.Size = new Size(160, 23);
        Controls.Add(cajaTextoPrecio);
        etiquetaCantidad.Location = new Point(20, 150);
        etiquetaCantidad.Name = "etiquetaCantidad";
        etiquetaCantidad.Size = new Size(80, 23);
        etiquetaCantidad.Text = "Cantidad";
        Controls.Add(etiquetaCantidad);
        cajaTextoCantidad.Location = new Point(110, 150);
        cajaTextoCantidad.Name = "cajaTextoCantidad";
        cajaTextoCantidad.Size = new Size(160, 23);
        Controls.Add(cajaTextoCantidad);
        listaVisualProductos.Location = new Point(20, 240);
        listaVisualProductos.Name = "listaVisualProductos";
        listaVisualProductos.Size = new Size(560, 170);
        Controls.Add(listaVisualProductos);
        botonAgregarProducto.Location = new Point(20, 190);
        botonAgregarProducto.Name = "botonAgregarProducto";
        botonAgregarProducto.Size = new Size(100, 30);
        botonAgregarProducto.Text = "Agregar";
        botonAgregarProducto.Click += botonAgregarProducto_Click;
        Controls.Add(botonAgregarProducto);
        botonBuscarProducto.Location = new Point(130, 190);
        botonBuscarProducto.Name = "botonBuscarProducto";
        botonBuscarProducto.Size = new Size(100, 30);
        botonBuscarProducto.Text = "Buscar";
        botonBuscarProducto.Click += botonBuscarProducto_Click;
        Controls.Add(botonBuscarProducto);
        botonEliminarProducto.Location = new Point(240, 190);
        botonEliminarProducto.Name = "botonEliminarProducto";
        botonEliminarProducto.Size = new Size(100, 30);
        botonEliminarProducto.Text = "Eliminar";
        botonEliminarProducto.Click += botonEliminarProducto_Click;
        Controls.Add(botonEliminarProducto);
        botonMostrarProductos.Location = new Point(350, 190);
        botonMostrarProductos.Name = "botonMostrarProductos";
        botonMostrarProductos.Size = new Size(100, 30);
        botonMostrarProductos.Text = "Mostrar";
        botonMostrarProductos.Click += botonMostrarProductos_Click;
        Controls.Add(botonMostrarProductos);
        botonLimpiarProductos.Location = new Point(460, 190);
        botonLimpiarProductos.Name = "botonLimpiarProductos";
        botonLimpiarProductos.Size = new Size(100, 30);
        botonLimpiarProductos.Text = "Limpiar";
        botonLimpiarProductos.Click += botonLimpiarProductos_Click;
        Controls.Add(botonLimpiarProductos);
        ClientSize = new Size(600, 450);
        Name = "FormularioInventario";
        Text = "Inventario de Productos";
        ResumeLayout(false);
        PerformLayout();
    }
}
