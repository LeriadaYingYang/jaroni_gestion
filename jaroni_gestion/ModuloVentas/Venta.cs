namespace jaroni_gestion.Datos;

public class Venta
{
    public int Codigo { get; set; }
    public string NombreProducto { get; set; } = string.Empty;
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal Total { get { return Cantidad * Precio; } }
}
