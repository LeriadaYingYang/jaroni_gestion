using jaroni_gestion.Datos;

namespace jaroni_gestion.Formularios;

public partial class FormularioVentas : Form
{
    public FormularioVentas()
    {
        InitializeComponent();
        MostrarVentas();
    }

    private void MostrarVentas()
    {
        listaVisualVentas.Items.Clear();
        List<Venta> ventas = MemoriaTemporal.Ventas.ObtenerTodos();
        foreach (Venta venta in ventas)
            listaVisualVentas.Items.Add(venta.Codigo + " - " + venta.NombreProducto + " - Cantidad: " + venta.Cantidad + " - Precio: " + venta.Precio + " - Total: " + venta.Total);
    }

    private void botonRegistrarVenta_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoCodigo.Text, out int codigo) ||
            !int.TryParse(cajaTextoCantidad.Text, out int cantidad) ||
            !decimal.TryParse(cajaTextoPrecio.Text, out decimal precio))
        {
            MessageBox.Show("Ingrese un código, cantidad y precio válidos.");
            return;
        }
        string nombreProducto = cajaTextoProducto.Text.Trim();
        if (nombreProducto.Length == 0)
        {
            MessageBox.Show("Ingrese el nombre del producto.");
            return;
        }
        Venta venta = new Venta();
        venta.Codigo = codigo;
        venta.NombreProducto = nombreProducto;
        venta.Cantidad = cantidad;
        venta.Precio = precio;
        try
        {
            decimal total = venta.Total;
        }
        catch (OverflowException)
        {
            MessageBox.Show("El total es demasiado grande.");
            return;
        }
        MemoriaTemporal.Ventas.Apilar(venta);
        MostrarVentas();
    }

    private void botonDeshacerVenta_Click(object sender, EventArgs e)
    {
        if (MemoriaTemporal.Ventas.EstaVacia)
        {
            MessageBox.Show("No hay ventas para deshacer.");
            return;
        }
        MemoriaTemporal.Ventas.Desapilar();
        MostrarVentas();
    }

    private void botonConsultarCima_Click(object sender, EventArgs e)
    {
        if (MemoriaTemporal.Ventas.EstaVacia)
        {
            MessageBox.Show("No hay ventas registradas.");
            return;
        }
        Venta venta = MemoriaTemporal.Ventas.VerCima();
        MessageBox.Show("Última venta: " + venta.Codigo + " - " + venta.NombreProducto + " - Total: " + venta.Total);
    }

    private void botonMostrarVentas_Click(object sender, EventArgs e)
    {
        MostrarVentas();
    }

    private void botonLimpiarVentas_Click(object sender, EventArgs e)
    {
        MemoriaTemporal.Ventas.Limpiar();
        MostrarVentas();
    }
}
