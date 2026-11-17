using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class NodoCliente
{
    public Cliente Cliente { get; set; }
    public NodoCliente? Izquierda { get; set; }
    public NodoCliente? Derecha { get; set; }

    public NodoCliente(Cliente cliente)
    {
        Cliente = cliente;
    }
}
