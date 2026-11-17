using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class NodoVenta
{
    public Venta Venta { get; set; }
    public NodoVenta? Siguiente { get; set; }

    public NodoVenta(Venta venta)
    {
        Venta = venta;
    }
}
