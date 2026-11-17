namespace jaroni_gestion;

partial class FormularioPrincipal
{
    private System.ComponentModel.IContainer components = null;
    private Panel panelMenuLateral;
    private Panel panelContenidoPrincipal;
    private Button botonInicio;
    private Button botonInventario;
    private Button botonCotizaciones;
    private Button botonRepartos;
    private Button botonVentas;
    private Button botonPedidos;
    private Button botonClientes;
    private Button botonRedDistribucion;
    private Button botonSalir;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        panelMenuLateral = new Panel();
        panelContenidoPrincipal = new Panel();
        botonInicio = new Button();
        botonInventario = new Button();
        botonCotizaciones = new Button();
        botonRepartos = new Button();
        botonVentas = new Button();
        botonPedidos = new Button();
        botonClientes = new Button();
        botonRedDistribucion = new Button();
        botonSalir = new Button();
        panelMenuLateral.SuspendLayout();
        SuspendLayout();
        panelMenuLateral.Dock = DockStyle.Left;
        panelMenuLateral.Name = "panelMenuLateral";
        panelMenuLateral.Size = new Size(180, 500);
        botonInicio.Location = new Point(10, 10);
        botonInicio.Name = "botonInicio";
        botonInicio.Size = new Size(160, 34);
        botonInicio.Text = "Inicio";
        botonInicio.UseVisualStyleBackColor = true;
        botonInicio.Click += botonInicio_Click;
        panelMenuLateral.Controls.Add(botonInicio);
        botonInventario.Location = new Point(10, 53);
        botonInventario.Name = "botonInventario";
        botonInventario.Size = new Size(160, 34);
        botonInventario.Text = "Inventario";
        botonInventario.UseVisualStyleBackColor = true;
        botonInventario.Click += botonInventario_Click;
        panelMenuLateral.Controls.Add(botonInventario);
        botonCotizaciones.Location = new Point(10, 96);
        botonCotizaciones.Name = "botonCotizaciones";
        botonCotizaciones.Size = new Size(160, 34);
        botonCotizaciones.Text = "Cotizaciones";
        botonCotizaciones.UseVisualStyleBackColor = true;
        botonCotizaciones.Click += botonCotizaciones_Click;
        panelMenuLateral.Controls.Add(botonCotizaciones);
        botonRepartos.Location = new Point(10, 139);
        botonRepartos.Name = "botonRepartos";
        botonRepartos.Size = new Size(160, 34);
        botonRepartos.Text = "Repartos";
        botonRepartos.UseVisualStyleBackColor = true;
        botonRepartos.Click += botonRepartos_Click;
        panelMenuLateral.Controls.Add(botonRepartos);
        botonVentas.Location = new Point(10, 182);
        botonVentas.Name = "botonVentas";
        botonVentas.Size = new Size(160, 34);
        botonVentas.Text = "Ventas";
        botonVentas.UseVisualStyleBackColor = true;
        botonVentas.Click += botonVentas_Click;
        panelMenuLateral.Controls.Add(botonVentas);
        botonPedidos.Location = new Point(10, 225);
        botonPedidos.Name = "botonPedidos";
        botonPedidos.Size = new Size(160, 34);
        botonPedidos.Text = "Pedidos";
        botonPedidos.UseVisualStyleBackColor = true;
        botonPedidos.Click += botonPedidos_Click;
        panelMenuLateral.Controls.Add(botonPedidos);
        botonClientes.Location = new Point(10, 268);
        botonClientes.Name = "botonClientes";
        botonClientes.Size = new Size(160, 34);
        botonClientes.Text = "Clientes";
        botonClientes.UseVisualStyleBackColor = true;
        botonClientes.Click += botonClientes_Click;
        panelMenuLateral.Controls.Add(botonClientes);
        botonRedDistribucion.Location = new Point(10, 311);
        botonRedDistribucion.Name = "botonRedDistribucion";
        botonRedDistribucion.Size = new Size(160, 34);
        botonRedDistribucion.Text = "Red de distribución";
        botonRedDistribucion.UseVisualStyleBackColor = true;
        botonRedDistribucion.Click += botonRedDistribucion_Click;
        panelMenuLateral.Controls.Add(botonRedDistribucion);
        botonSalir.Location = new Point(10, 354);
        botonSalir.Name = "botonSalir";
        botonSalir.Size = new Size(160, 34);
        botonSalir.Text = "Salir";
        botonSalir.UseVisualStyleBackColor = true;
        botonSalir.Click += botonSalir_Click;
        panelMenuLateral.Controls.Add(botonSalir);
        panelContenidoPrincipal.Dock = DockStyle.Fill;
        panelContenidoPrincipal.Name = "panelContenidoPrincipal";
        ClientSize = new Size(900, 500);
        Controls.Add(panelContenidoPrincipal);
        Controls.Add(panelMenuLateral);
        Name = "FormularioPrincipal";
        Text = "jaroni_gestion";
        panelMenuLateral.ResumeLayout(false);
        ResumeLayout(false);
    }
}
