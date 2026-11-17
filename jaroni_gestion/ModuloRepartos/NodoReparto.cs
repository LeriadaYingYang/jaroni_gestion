using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class NodoReparto
{
    public Reparto Reparto { get; set; }
    public NodoReparto? Siguiente { get; set; }

    public NodoReparto(Reparto reparto)
    {
        Reparto = reparto;
    }
}
