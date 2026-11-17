namespace jaroni_gestion.Datos;

public class Pedido
{
    public int CodigoCliente { get; set; }
    public int CodigoProducto { get; set; }
    public int NumeroTurno { get; set; }
    public string NombreCliente { get; set; } = string.Empty;
    public string NombreProducto { get; set; } = string.Empty;
    public int Cantidad { get; set; }
    public string Descripcion { get; set; } = string.Empty;
}
