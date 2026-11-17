namespace jaroni_gestion.Datos;

public class Venta
{
    public int CodigoCliente { get; set; }
    public int CodigoProducto { get; set; }
    public int Codigo { get; set; }
    public string DireccionCliente { get; set; } = string.Empty;
    public string NombreCliente { get; set; } = string.Empty;
    public string NombreProducto { get; set; } = string.Empty;
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal Total { get { return Cantidad * Precio; } }
}
