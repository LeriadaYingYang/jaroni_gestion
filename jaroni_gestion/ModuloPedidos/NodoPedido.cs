using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class NodoPedido
{
    public Pedido Pedido { get; set; }
    public NodoPedido? Siguiente { get; set; }

    public NodoPedido(Pedido pedido)
    {
        Pedido = pedido;
    }
}
