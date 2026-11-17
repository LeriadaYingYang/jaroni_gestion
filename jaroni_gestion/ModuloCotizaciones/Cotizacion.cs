namespace jaroni_gestion.Datos;

public class Cotizacion
{
    public int CodigoCliente { get; set; }
    public int CodigoProducto { get; set; }
    public int Numero { get; set; }
    public string NombreCliente { get; set; } = string.Empty;
    public string NombreProducto { get; set; } = string.Empty;
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal Total { get { return Cantidad * Precio; } }
}
