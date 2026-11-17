namespace jaroni_gestion.Formularios;

partial class FormularioPedidos
{
    private System.ComponentModel.IContainer components = null;
    private Label etiquetaTitulo;
    private Label etiquetaNumeroTurno;
    private TextBox cajaTextoNumeroTurno;
    private Label etiquetaCliente;
    private ComboBox listaDesplegableClientes;
    private Label etiquetaProducto;
    private ComboBox listaDesplegableProductos;
    private Label etiquetaCantidad;
    private TextBox cajaTextoCantidad;
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
        etiquetaCliente = new Label();
        listaDesplegableClientes = new ComboBox();
        etiquetaProducto = new Label();
        listaDesplegableProductos = new ComboBox();
        etiquetaCantidad = new Label();
        cajaTextoCantidad = new TextBox();
        botonRegistrarPedido = new Button();
        botonAtenderPedido = new Button();
        botonVerPrimerPedido = new Button();
        botonMostrarPedidos = new Button();
        botonLimpiarPedidos = new Button();
        etiquetaListaPedidos = new Label();
        listaVisualPedidos = new ListBox();
        SuspendLayout();
        etiquetaTitulo.Location = new Point(20, 10);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new Size(300, 23);
        etiquetaTitulo.Text = "Atención de Pedidos";
        Controls.Add(etiquetaTitulo);
        etiquetaNumeroTurno.Location = new Point(20, 40);
        etiquetaNumeroTurno.Name = "etiquetaNumeroTurno";
        etiquetaNumeroTurno.Size = new Size(120, 23);
        etiquetaNumeroTurno.Text = "Número de turno";
        Controls.Add(etiquetaNumeroTurno);
        cajaTextoNumeroTurno.Location = new Point(150, 40);
        cajaTextoNumeroTurno.Name = "cajaTextoNumeroTurno";
        cajaTextoNumeroTurno.Size = new Size(180, 23);
        Controls.Add(cajaTextoNumeroTurno);
        etiquetaCliente.Location = new Point(20, 70);
        etiquetaCliente.Name = "etiquetaCliente";
        etiquetaCliente.Size = new Size(120, 23);
        etiquetaCliente.Text = "Cliente";
        Controls.Add(etiquetaCliente);
        listaDesplegableClientes.Location = new Point(150, 70);
        listaDesplegableClientes.Name = "listaDesplegableClientes";
        listaDesplegableClientes.Size = new Size(350, 23);
        listaDesplegableClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        Controls.Add(listaDesplegableClientes);
        etiquetaProducto.Location = new Point(20, 100);
        etiquetaProducto.Name = "etiquetaProducto";
        etiquetaProducto.Size = new Size(120, 23);
        etiquetaProducto.Text = "Producto";
        Controls.Add(etiquetaProducto);
        listaDesplegableProductos.Location = new Point(150, 100);
        listaDesplegableProductos.Name = "listaDesplegableProductos";
        listaDesplegableProductos.Size = new Size(350, 23);
        listaDesplegableProductos.DropDownStyle = ComboBoxStyle.DropDownList;
        Controls.Add(listaDesplegableProductos);
        etiquetaCantidad.Location = new Point(20, 130);
        etiquetaCantidad.Name = "etiquetaCantidad";
        etiquetaCantidad.Size = new Size(120, 23);
        etiquetaCantidad.Text = "Cantidad";
        Controls.Add(etiquetaCantidad);
        cajaTextoCantidad.Location = new Point(150, 130);
        cajaTextoCantidad.Name = "cajaTextoCantidad";
        cajaTextoCantidad.Size = new Size(100, 23);
        Controls.Add(cajaTextoCantidad);
        botonRegistrarPedido.Location = new Point(20, 165);
        botonRegistrarPedido.Name = "botonRegistrarPedido";
        botonRegistrarPedido.Size = new Size(100, 30);
        botonRegistrarPedido.Text = "Registrar";
        botonRegistrarPedido.Click += botonRegistrarPedido_Click;
        Controls.Add(botonRegistrarPedido);
        botonAtenderPedido.Location = new Point(130, 165);
        botonAtenderPedido.Name = "botonAtenderPedido";
        botonAtenderPedido.Size = new Size(100, 30);
        botonAtenderPedido.Text = "Atender";
        botonAtenderPedido.Click += botonAtenderPedido_Click;
        Controls.Add(botonAtenderPedido);
        botonVerPrimerPedido.Location = new Point(240, 165);
        botonVerPrimerPedido.Name = "botonVerPrimerPedido";
        botonVerPrimerPedido.Size = new Size(100, 30);
        botonVerPrimerPedido.Text = "Ver primero";
        botonVerPrimerPedido.Click += botonVerPrimerPedido_Click;
        Controls.Add(botonVerPrimerPedido);
        botonMostrarPedidos.Location = new Point(350, 165);
        botonMostrarPedidos.Name = "botonMostrarPedidos";
        botonMostrarPedidos.Size = new Size(100, 30);
        botonMostrarPedidos.Text = "Mostrar";
        botonMostrarPedidos.Click += botonMostrarPedidos_Click;
        Controls.Add(botonMostrarPedidos);
        botonLimpiarPedidos.Location = new Point(460, 165);
        botonLimpiarPedidos.Name = "botonLimpiarPedidos";
        botonLimpiarPedidos.Size = new Size(100, 30);
        botonLimpiarPedidos.Text = "Limpiar";
        botonLimpiarPedidos.Click += botonLimpiarPedidos_Click;
        Controls.Add(botonLimpiarPedidos);
        etiquetaListaPedidos.Location = new Point(20, 205);
        etiquetaListaPedidos.Name = "etiquetaListaPedidos";
        etiquetaListaPedidos.Size = new Size(350, 23);
        etiquetaListaPedidos.Text = "Pedidos en orden de llegada:";
        Controls.Add(etiquetaListaPedidos);
        listaVisualPedidos.Location = new Point(20, 230);
        listaVisualPedidos.Name = "listaVisualPedidos";
        listaVisualPedidos.Size = new Size(560, 170);
        Controls.Add(listaVisualPedidos);
        ClientSize = new Size(600, 450);
        Name = "FormularioPedidos";
        Text = "Atención de Pedidos";
        ResumeLayout(false);
        PerformLayout();
    }
}
