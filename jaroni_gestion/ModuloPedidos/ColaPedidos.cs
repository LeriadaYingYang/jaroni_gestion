using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class ColaPedidos
{
    private NodoPedido? frente;
    private NodoPedido? final;

    public bool EstaVacia { get { return frente == null; } }

    public void Encolar(Pedido pedido)
    {
        NodoPedido nuevoNodoPedido = new NodoPedido(pedido);
        // El primer pedido es el frente; los demás se enlazan al final.
        if (final == null)
            frente = nuevoNodoPedido;
        else
            final.Siguiente = nuevoNodoPedido;
        final = nuevoNodoPedido;
    }

    public Pedido Desencolar()
    {
        if (frente == null)
            throw new InvalidOperationException("La cola está vacía.");
        Pedido pedido = frente.Pedido;
        // El siguiente nodo pasa al frente; si no queda ninguno, se vacía el final.
        frente = frente.Siguiente;
        if (frente == null)
            final = null;
        return pedido;
    }

    public Pedido VerFrente()
    {
        if (frente == null)
            throw new InvalidOperationException("La cola está vacía.");
        return frente.Pedido;
    }

    public List<Pedido> ObtenerTodos()
    {
        List<Pedido> pedidos = new List<Pedido>();
        NodoPedido? nodoActual = frente;
        while (nodoActual != null)
        {
            pedidos.Add(nodoActual.Pedido);
            nodoActual = nodoActual.Siguiente;
        }
        return pedidos;
    }

    public void Limpiar()
    {
        // Al quitar ambas referencias, la cola queda vacía.
        frente = null;
        final = null;
    }
}
