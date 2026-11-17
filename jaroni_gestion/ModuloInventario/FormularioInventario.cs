using jaroni_gestion.Datos;

namespace jaroni_gestion.Formularios;

public partial class FormularioInventario : Form
{
    public FormularioInventario()
    {
        InitializeComponent();
        MostrarProductos();
    }

    private void MostrarProductos()
    {
        listaVisualProductos.Items.Clear();
        List<Producto> productos = MemoriaTemporal.Productos.ObtenerTodos();
        foreach (Producto producto in productos)
            listaVisualProductos.Items.Add(producto.Codigo + " - " + producto.Nombre + " - Precio: " + producto.Precio + " - Cantidad: " + producto.Cantidad);
    }

    private void botonAgregarProducto_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoCodigo.Text, out int codigo) ||
            !decimal.TryParse(cajaTextoPrecio.Text, out decimal precio) ||
            !int.TryParse(cajaTextoCantidad.Text, out int cantidad))
        {
            MessageBox.Show("Ingrese un código, precio y cantidad válidos.");
            return;
        }
        string nombre = cajaTextoNombre.Text.Trim();
        if (nombre.Length == 0)
        {
            MessageBox.Show("Ingrese el nombre del producto.");
            return;
        }
        Producto producto = new Producto();
        producto.Codigo = codigo;
        producto.Nombre = nombre;
        producto.Precio = precio;
        producto.Cantidad = cantidad;
        MemoriaTemporal.Productos.Agregar(producto);
        MostrarProductos();
    }

    private void botonBuscarProducto_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(cajaTextoCodigo.Text, out int codigo))
        {
            MessageBox.Show("Ingrese un código válido para buscar.");
            return;
        }
        int indice = MemoriaTemporal.Productos.Buscar(codigo);
        if (indice == -1)
        {
            listaVisualProductos.ClearSelected();
            MessageBox.Show("Producto no encontrado.");
            return;
        }
        listaVisualProductos.SelectedIndex = indice;
    }

    private void botonEliminarProducto_Click(object sender, EventArgs e)
    {
        int indice = listaVisualProductos.SelectedIndex;
        if (indice < 0)
        {
            MessageBox.Show("Seleccione un producto para eliminar.");
            return;
        }
        MemoriaTemporal.Productos.Eliminar(indice);
        MostrarProductos();
    }

    private void botonMostrarProductos_Click(object sender, EventArgs e)
    {
        MostrarProductos();
    }

    private void botonLimpiarProductos_Click(object sender, EventArgs e)
    {
        MemoriaTemporal.Productos.Limpiar();
        MostrarProductos();
    }
}
