using jaroni_gestion.Datos;

namespace jaroni_gestion.Estructuras;

public class NodoCotizacion
{
    public Cotizacion Cotizacion { get; set; }
    public NodoCotizacion? Anterior { get; set; }
    public NodoCotizacion? Siguiente { get; set; }

    public NodoCotizacion(Cotizacion cotizacion)
    {
        Cotizacion = cotizacion;
    }
}
