using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class NodoProducto
{
    public Producto Producto { get; set; }
    public NodoProducto? Siguiente { get; set; }

    public NodoProducto(Producto producto)
    {
        Producto = producto;
        Siguiente = null;
    }
}
