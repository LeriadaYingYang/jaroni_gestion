using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class ListaProductos
{
    private NodoProducto? cabeza;
    private int cantidadProductos;

    public int CantidadProductos { get { return cantidadProductos; } }

    public void Agregar(Producto producto)
    {
        // El nuevo nodo se enlaza al final de la lista.
        NodoProducto nuevoNodoProducto = new NodoProducto(producto);
        if (cabeza == null)
            cabeza = nuevoNodoProducto;
        else
        {
            NodoProducto nodoActual = cabeza;
            while (nodoActual.Siguiente != null)
                nodoActual = nodoActual.Siguiente;
            nodoActual.Siguiente = nuevoNodoProducto;
        }
        cantidadProductos++;
    }

    public int Buscar(int codigo)
    {
        NodoProducto? nodoActual = cabeza;
        int indice = 0;
        while (nodoActual != null)
        {
            if (nodoActual.Producto.Codigo == codigo)
                return indice;
            nodoActual = nodoActual.Siguiente;
            indice++;
        }
        return -1;
    }

    public bool Eliminar(int indice)
    {
        if (indice < 0 || indice >= cantidadProductos || cabeza == null)
            return false;

        // Se actualiza la cabeza o se omite el nodo que se elimina.
        if (indice == 0)
            cabeza = cabeza.Siguiente;
        else
        {
            NodoProducto nodoActual = cabeza;
            for (int posicion = 0; posicion < indice - 1; posicion++)
                nodoActual = nodoActual.Siguiente!;
            nodoActual.Siguiente = nodoActual.Siguiente!.Siguiente;
        }
        cantidadProductos--;
        return true;
    }

    public List<Producto> ObtenerTodos()
    {
        List<Producto> productos = new List<Producto>();
        NodoProducto? nodoActual = cabeza;
        while (nodoActual != null)
        {
            productos.Add(nodoActual.Producto);
            nodoActual = nodoActual.Siguiente;
        }
        return productos;
    }

    public void Limpiar()
    {
        // Al quitar la cabeza, la lista queda vacía.
        cabeza = null;
        cantidadProductos = 0;
    }
}
