using jaroni_gestion.Estructuras;

namespace jaroni_gestion;

public static class MemoriaTemporal
{
    public static ListaCotizaciones Cotizaciones { get; } = new ListaCotizaciones();
    public static ListaCircularRepartos Repartos { get; } = new ListaCircularRepartos();
    public static PilaVentas Ventas { get; } = new PilaVentas();
    public static ColaPedidos Pedidos { get; } = new ColaPedidos();
    public static ArbolClientes Clientes { get; } = new ArbolClientes();
    public static ListaProductos Productos { get; } = new ListaProductos();
}
