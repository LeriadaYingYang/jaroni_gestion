using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class ArbolClientes
{
    private NodoCliente? raiz;

    public bool Insertar(Cliente cliente)
    {
        if (Buscar(cliente.Codigo) != null)
            return false;
        raiz = InsertarNodo(raiz, cliente);
        return true;
    }

    private NodoCliente InsertarNodo(NodoCliente? nodoActual, Cliente cliente)
    {
        if (nodoActual == null)
            return new NodoCliente(cliente);
        if (cliente.Codigo < nodoActual.Cliente.Codigo)
            nodoActual.Izquierda = InsertarNodo(nodoActual.Izquierda, cliente);
        else
            nodoActual.Derecha = InsertarNodo(nodoActual.Derecha, cliente);
        return nodoActual;
    }

    public Cliente? Buscar(int codigo)
    {
        return BuscarNodo(raiz, codigo);
    }

    private Cliente? BuscarNodo(NodoCliente? nodoActual, int codigo)
    {
        if (nodoActual == null)
            return null;
        if (codigo == nodoActual.Cliente.Codigo)
            return nodoActual.Cliente;
        if (codigo < nodoActual.Cliente.Codigo)
            return BuscarNodo(nodoActual.Izquierda, codigo);
        return BuscarNodo(nodoActual.Derecha, codigo);
    }

    public bool Eliminar(int codigo)
    {
        if (Buscar(codigo) == null)
            return false;
        raiz = EliminarNodo(raiz, codigo);
        return true;
    }

    private NodoCliente? EliminarNodo(NodoCliente? nodoActual, int codigo)
    {
        if (nodoActual == null)
            return null;
        if (codigo < nodoActual.Cliente.Codigo)
            nodoActual.Izquierda = EliminarNodo(nodoActual.Izquierda, codigo);
        else if (codigo > nodoActual.Cliente.Codigo)
            nodoActual.Derecha = EliminarNodo(nodoActual.Derecha, codigo);
        else
        {
            // El hijo reemplaza al nodo si falta una de las ramas.
            if (nodoActual.Izquierda == null)
                return nodoActual.Derecha;
            if (nodoActual.Derecha == null)
                return nodoActual.Izquierda;

            // Con dos hijos, se usa el menor nodo del subárbol derecho.
            NodoCliente nodoSucesor = nodoActual.Derecha;
            while (nodoSucesor.Izquierda != null)
                nodoSucesor = nodoSucesor.Izquierda;
            nodoActual.Cliente = nodoSucesor.Cliente;
            nodoActual.Derecha = EliminarNodo(nodoActual.Derecha, nodoSucesor.Cliente.Codigo);
        }
        return nodoActual;
    }

    public List<Cliente> Preorden()
    {
        List<Cliente> clientes = new List<Cliente>();
        RecorrerPreorden(raiz, clientes);
        return clientes;
    }

    private void RecorrerPreorden(NodoCliente? nodoActual, List<Cliente> clientes)
    {
        if (nodoActual == null)
            return;
        clientes.Add(nodoActual.Cliente);
        RecorrerPreorden(nodoActual.Izquierda, clientes);
        RecorrerPreorden(nodoActual.Derecha, clientes);
    }

    public List<Cliente> Inorden()
    {
        List<Cliente> clientes = new List<Cliente>();
        RecorrerInorden(raiz, clientes);
        return clientes;
    }

    private void RecorrerInorden(NodoCliente? nodoActual, List<Cliente> clientes)
    {
        if (nodoActual == null)
            return;
        RecorrerInorden(nodoActual.Izquierda, clientes);
        clientes.Add(nodoActual.Cliente);
        RecorrerInorden(nodoActual.Derecha, clientes);
    }

    public List<Cliente> Postorden()
    {
        List<Cliente> clientes = new List<Cliente>();
        RecorrerPostorden(raiz, clientes);
        return clientes;
    }

    private void RecorrerPostorden(NodoCliente? nodoActual, List<Cliente> clientes)
    {
        if (nodoActual == null)
            return;
        RecorrerPostorden(nodoActual.Izquierda, clientes);
        RecorrerPostorden(nodoActual.Derecha, clientes);
        clientes.Add(nodoActual.Cliente);
    }
}
