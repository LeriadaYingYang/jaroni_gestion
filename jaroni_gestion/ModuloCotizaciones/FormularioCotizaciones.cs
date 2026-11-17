using jaroni_gestion.Datos;
using jaroni_gestion.Estructuras;

namespace jaroni_gestion.Formularios;

public partial class FormularioCotizaciones : Form
{
    private NodoCotizacion? nodoActual;

    public FormularioCotizaciones()
    {
        InitializeComponent();
        nodoActual = MemoriaTemporal.Cotizaciones.ObtenerCabeza();
        MostrarCotizacionActual();
    }

    private void MostrarCotizacionActual()
    {
        if (nodoActual == null)
        {
            etiquetaCotizacionActual.Text = "Cotización actual: ninguna";
            return;
        }
        Cotizacion cotizacion = nodoActual.Cotizacion;
        etiquetaCotizacionActual.Text = "Número: " + cotizacion.Numero +
            "\nCliente: " + cotizacion.NombreCliente +
            "\nProducto: " + cotizacion.NombreProducto +
            "\nCantidad: " + cotizacion.Cantidad +
            "\nPrecio: " + cotizacion.Precio +
            "\nTotal: " + cotizacion.Total;
    }

    private void botonRegistrarCotizacion_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoNumero.Text, out int numero) ||
            !int.TryParse(cajaTextoCantidad.Text, out int cantidad) ||
            !decimal.TryParse(cajaTextoPrecio.Text, out decimal precio))
        {
            MessageBox.Show("Ingrese un número, cantidad y precio válidos.");
            return;
        }
        string nombreCliente = cajaTextoCliente.Text.Trim();
        string nombreProducto = cajaTextoProducto.Text.Trim();
        if (nombreCliente.Length == 0 || nombreProducto.Length == 0)
        {
            MessageBox.Show("Ingrese el cliente y el producto.");
            return;
        }
        Cotizacion cotizacion = new Cotizacion();
        cotizacion.Numero = numero;
        cotizacion.NombreCliente = nombreCliente;
        cotizacion.NombreProducto = nombreProducto;
        cotizacion.Cantidad = cantidad;
        cotizacion.Precio = precio;
        try
        {
            decimal total = cotizacion.Total;
        }
        catch (OverflowException)
        {
            MessageBox.Show("El total es demasiado grande.");
            return;
        }
        MemoriaTemporal.Cotizaciones.AgregarFinal(cotizacion);
        nodoActual = MemoriaTemporal.Cotizaciones.ObtenerCola();
        MostrarCotizacionActual();
    }

    private void botonConsultarCotizacion_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoNumero.Text, out int numero))
        {
            MessageBox.Show("Ingrese un número válido para consultar.");
            return;
        }
        NodoCotizacion? nodoEncontrado = MemoriaTemporal.Cotizaciones.Buscar(numero);
        if (nodoEncontrado == null)
        {
            MessageBox.Show("Cotización no encontrada.");
            return;
        }
        nodoActual = nodoEncontrado;
        MostrarCotizacionActual();
    }

    private void botonEliminarCotizacion_Click(object sender, EventArgs e)
    {
        if (nodoActual == null)
        {
            MessageBox.Show("No hay una cotización para eliminar.");
            return;
        }
        NodoCotizacion nodoEliminar = nodoActual;
        nodoActual = nodoEliminar.Siguiente ?? nodoEliminar.Anterior;
        MemoriaTemporal.Cotizaciones.Eliminar(nodoEliminar);
        MostrarCotizacionActual();
    }

    private void botonAnterior_Click(object sender, EventArgs e)
    {
        if (nodoActual == null || nodoActual.Anterior == null)
        {
            MessageBox.Show("No hay una cotización anterior.");
            return;
        }
        nodoActual = nodoActual.Anterior;
        MostrarCotizacionActual();
    }

    private void botonSiguiente_Click(object sender, EventArgs e)
    {
        if (nodoActual == null || nodoActual.Siguiente == null)
        {
            MessageBox.Show("No hay una cotización siguiente.");
            return;
        }
        nodoActual = nodoActual.Siguiente;
        MostrarCotizacionActual();
    }
}
