using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class PilaVentas
{
    private NodoVenta? cima;

    public bool EstaVacia { get { return cima == null; } }

    public void Apilar(Venta venta)
    {
        // El nuevo nodo apunta a la cima anterior y pasa a ser la cima.
        NodoVenta nuevoNodoVenta = new NodoVenta(venta);
        nuevoNodoVenta.Siguiente = cima;
        cima = nuevoNodoVenta;
    }

    public Venta Desapilar()
    {
        if (cima == null)
            throw new InvalidOperationException("La pila está vacía.");
        Venta venta = cima.Venta;
        // La cima pasa al siguiente nodo.
        cima = cima.Siguiente;
        return venta;
    }

    public Venta VerCima()
    {
        if (cima == null)
            throw new InvalidOperationException("La pila está vacía.");
        return cima.Venta;
    }

    public List<Venta> ObtenerTodos()
    {
        List<Venta> ventas = new List<Venta>();
        NodoVenta? nodoActual = cima;
        while (nodoActual != null)
        {
            ventas.Add(nodoActual.Venta);
            nodoActual = nodoActual.Siguiente;
        }
        return ventas;
    }

    public void Limpiar()
    {
        // La pila queda vacía al quitar la referencia a la cima.
        cima = null;
    }
}
