namespace jaroni_gestion.Datos;

public class Cliente
{
    public int Codigo { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string TipoCliente { get; set; } = string.Empty;
    public override string ToString()
    {
        return Codigo + " - " + Nombre;
    }
}
