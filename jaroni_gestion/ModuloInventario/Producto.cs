namespace jaroni_gestion.Datos;

public class Producto
{
    public int Codigo { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
    public override string ToString()
    {
        return Codigo + " - " + Nombre;
    }
}
