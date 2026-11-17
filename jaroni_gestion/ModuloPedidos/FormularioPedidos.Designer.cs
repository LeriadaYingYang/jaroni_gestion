namespace jaroni_gestion.Formularios;

partial class FormularioPedidos
{
    private System.ComponentModel.IContainer components = null;
    private Label etiquetaTitulo;
    private Label etiquetaNumeroTurno;
    private TextBox cajaTextoNumeroTurno;
    private Label etiquetaNombreCliente;
    private TextBox cajaTextoNombreCliente;
    private Label etiquetaDescripcion;
    private TextBox cajaTextoDescripcion;
    private Button botonRegistrarPedido;
    private Button botonAtenderPedido;
    private Button botonVerPrimerPedido;
    private Button botonMostrarPedidos;
    private Button botonLimpiarPedidos;
    private Label etiquetaListaPedidos;
    private ListBox listaVisualPedidos;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        etiquetaTitulo = new Label();
        etiquetaNumeroTurno = new Label();
        cajaTextoNumeroTurno = new TextBox();
        etiquetaNombreCliente = new Label();
        cajaTextoNombreCliente = new TextBox();
        etiquetaDescripcion = new Label();
        cajaTextoDescripcion = new TextBox();
        botonRegistrarPedido = new Button();
        botonAtenderPedido = new Button();
        botonVerPrimerPedido = new Button();
        botonMostrarPedidos = new Button();
        botonLimpiarPedidos = new Button();
        etiquetaListaPedidos = new Label();
        listaVisualPedidos = new ListBox();
        SuspendLayout();
        etiquetaTitulo.Location = new Point(20, 15);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new Size(300, 24);
        etiquetaTitulo.Text = "Atención de Pedidos";
        Controls.Add(etiquetaTitulo);
        etiquetaNumeroTurno.Location = new Point(20, 50);
        etiquetaNumeroTurno.Name = "etiquetaNumeroTurno";
        etiquetaNumeroTurno.Size = new Size(120, 23);
        etiquetaNumeroTurno.Text = "Número de turno";
        Controls.Add(etiquetaNumeroTurno);
        cajaTextoNumeroTurno.Location = new Point(150, 50);
        cajaTextoNumeroTurno.Name = "cajaTextoNumeroTurno";
        cajaTextoNumeroTurno.Size = new Size(180, 23);
        Controls.Add(cajaTextoNumeroTurno);
        etiquetaNombreCliente.Location = new Point(20, 80);
        etiquetaNombreCliente.Name = "etiquetaNombreCliente";
        etiquetaNombreCliente.Size = new Size(120, 23);
        etiquetaNombreCliente.Text = "Cliente";
        Controls.Add(etiquetaNombreCliente);
        cajaTextoNombreCliente.Location = new Point(150, 80);
        cajaTextoNombreCliente.Name = "cajaTextoNombreCliente";
        cajaTextoNombreCliente.Size = new Size(250, 23);
        Controls.Add(cajaTextoNombreCliente);
        etiquetaDescripcion.Location = new Point(20, 110);
        etiquetaDescripcion.Name = "etiquetaDescripcion";
        etiquetaDescripcion.Size = new Size(120, 23);
        etiquetaDescripcion.Text = "Descripción";
        Controls.Add(etiquetaDescripcion);
        cajaTextoDescripcion.Location = new Point(150, 110);
        cajaTextoDescripcion.Name = "cajaTextoDescripcion";
        cajaTextoDescripcion.Size = new Size(350, 23);
        Controls.Add(cajaTextoDescripcion);
        botonRegistrarPedido.Location = new Point(20, 150);
        botonRegistrarPedido.Name = "botonRegistrarPedido";
        botonRegistrarPedido.Size = new Size(100, 30);
        botonRegistrarPedido.Text = "Registrar";
        botonRegistrarPedido.Click += botonRegistrarPedido_Click;
        Controls.Add(botonRegistrarPedido);
        botonAtenderPedido.Location = new Point(130, 150);
        botonAtenderPedido.Name = "botonAtenderPedido";
        botonAtenderPedido.Size = new Size(100, 30);
        botonAtenderPedido.Text = "Atender";
        botonAtenderPedido.Click += botonAtenderPedido_Click;
        Controls.Add(botonAtenderPedido);
        botonVerPrimerPedido.Location = new Point(240, 150);
        botonVerPrimerPedido.Name = "botonVerPrimerPedido";
        botonVerPrimerPedido.Size = new Size(100, 30);
        botonVerPrimerPedido.Text = "Ver primero";
        botonVerPrimerPedido.Click += botonVerPrimerPedido_Click;
        Controls.Add(botonVerPrimerPedido);
        botonMostrarPedidos.Location = new Point(350, 150);
        botonMostrarPedidos.Name = "botonMostrarPedidos";
        botonMostrarPedidos.Size = new Size(100, 30);
        botonMostrarPedidos.Text = "Mostrar";
        botonMostrarPedidos.Click += botonMostrarPedidos_Click;
        Controls.Add(botonMostrarPedidos);
        botonLimpiarPedidos.Location = new Point(460, 150);
        botonLimpiarPedidos.Name = "botonLimpiarPedidos";
        botonLimpiarPedidos.Size = new Size(100, 30);
        botonLimpiarPedidos.Text = "Limpiar";
        botonLimpiarPedidos.Click += botonLimpiarPedidos_Click;
        Controls.Add(botonLimpiarPedidos);
        etiquetaListaPedidos.Location = new Point(20, 195);
        etiquetaListaPedidos.Name = "etiquetaListaPedidos";
        etiquetaListaPedidos.Size = new Size(300, 23);
        etiquetaListaPedidos.Text = "Pedidos en orden de llegada:";
        Controls.Add(etiquetaListaPedidos);
        listaVisualPedidos.Location = new Point(20, 225);
        listaVisualPedidos.Name = "listaVisualPedidos";
        listaVisualPedidos.Size = new Size(560, 175);
        Controls.Add(listaVisualPedidos);
        ClientSize = new Size(600, 450);
        Name = "FormularioPedidos";
        Text = "Atención de Pedidos";
        ResumeLayout(false);
        PerformLayout();
    }
}
