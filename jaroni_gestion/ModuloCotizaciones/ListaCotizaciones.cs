using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class ListaCotizaciones
{
    private NodoCotizacion? cabeza;
    private NodoCotizacion? cola;

    public void AgregarFinal(Cotizacion cotizacion)
    {
        NodoCotizacion nuevoNodoCotizacion = new NodoCotizacion(cotizacion);
        // El primer nodo es a la vez cabeza y cola.
        if (cola == null)
        {
            cabeza = nuevoNodoCotizacion;
            cola = nuevoNodoCotizacion;
        }
        else
        {
            cola.Siguiente = nuevoNodoCotizacion;
            nuevoNodoCotizacion.Anterior = cola;
            cola = nuevoNodoCotizacion;
        }
    }

    public NodoCotizacion? Buscar(int numero)
    {
        NodoCotizacion? nodoActual = cabeza;
        while (nodoActual != null)
        {
            if (nodoActual.Cotizacion.Numero == numero)
                return nodoActual;
            nodoActual = nodoActual.Siguiente;
        }
        return null;
    }

    public bool Eliminar(NodoCotizacion? nodo)
    {
        if (nodo == null)
            return false;

        // Los enlaces vecinos sustituyen al nodo eliminado.
        if (nodo.Anterior == null)
            cabeza = nodo.Siguiente;
        else
            nodo.Anterior.Siguiente = nodo.Siguiente;

        if (nodo.Siguiente == null)
            cola = nodo.Anterior;
        else
            nodo.Siguiente.Anterior = nodo.Anterior;

        return true;
    }

    public NodoCotizacion? ObtenerCabeza()
    {
        return cabeza;
    }

    public NodoCotizacion? ObtenerCola()
    {
        return cola;
    }
}
