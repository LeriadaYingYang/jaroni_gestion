using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class ListaCircularRepartos
{
    private NodoReparto? cola;
    private NodoReparto? nodoActual;

    public Reparto? ParadaActual
    {
        get { return nodoActual == null ? null : nodoActual.Reparto; }
    }

    public void Agregar(Reparto reparto)
    {
        NodoReparto nuevoNodoReparto = new NodoReparto(reparto);
        // El primer nodo apunta a sí mismo; los siguientes cierran el círculo.
        if (cola == null)
        {
            nuevoNodoReparto.Siguiente = nuevoNodoReparto;
            cola = nuevoNodoReparto;
            nodoActual = nuevoNodoReparto;
        }
        else
        {
            nuevoNodoReparto.Siguiente = cola.Siguiente;
            cola.Siguiente = nuevoNodoReparto;
            cola = nuevoNodoReparto;
        }
    }

    public bool Eliminar(int indice)
    {
        if (cola == null || indice < 0)
            return false;

        NodoReparto nodoInicial = cola.Siguiente!;
        NodoReparto nodoAnterior = cola;
        NodoReparto nodoRecorrido = nodoInicial;
        int posicion = 0;
        do
        {
            if (posicion == indice)
            {
                // Se reconectan los nodos y se actualizan la cola y el turno.
                if (nodoRecorrido == nodoAnterior)
                {
                    cola = null;
                    nodoActual = null;
                }
                else
                {
                    nodoAnterior.Siguiente = nodoRecorrido.Siguiente;
                    if (nodoRecorrido == cola)
                        cola = nodoAnterior;
                    if (nodoRecorrido == nodoActual)
                        nodoActual = nodoRecorrido.Siguiente;
                }
                nodoRecorrido.Siguiente = null;
                return true;
            }
            nodoAnterior = nodoRecorrido;
            nodoRecorrido = nodoRecorrido.Siguiente!;
            posicion++;
        } while (nodoRecorrido != nodoInicial);
        return false;
    }

    public List<Reparto> ObtenerTodos()
    {
        List<Reparto> repartos = new List<Reparto>();
        if (cola == null)
            return repartos;

        NodoReparto nodoInicial = cola.Siguiente!;
        NodoReparto nodoRecorrido = nodoInicial;
        do
        {
            repartos.Add(nodoRecorrido.Reparto);
            nodoRecorrido = nodoRecorrido.Siguiente!;
        } while (nodoRecorrido != nodoInicial);
        return repartos;
    }

    public void Avanzar()
    {
        if (nodoActual != null)
            nodoActual = nodoActual.Siguiente;
    }
}
