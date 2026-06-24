namespace NexaMobileLite.Helpers;

public static class ApiConfig
{
    public const string BaseUrl = "https://www.zeezton.cl";

    public static string ProductosUrl => $"{BaseUrl}/api/productos/";
    public static string ClientesUrl => $"{BaseUrl}/api/clientes/";
    public static string CrearClienteUrl => $"{BaseUrl}/api/clientes/crear/";
    public static string BuscarClienteUrl(string rut) => $"{BaseUrl}/api/clientes/buscar/?rut={rut}";
    public static string VentasUrl => $"{BaseUrl}/api/ventas/";

    public static string PedidosUrl => $"{BaseUrl}/api/pedidos/";
}