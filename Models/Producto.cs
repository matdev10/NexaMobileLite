using System.Text.Json.Serialization;

namespace NexaMobileLite.Models;

public class Producto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nombre")]
    public string Nombre { get; set; } = "";

    [JsonPropertyName("descripcion")]
    public string Descripcion { get; set; } = "";

    [JsonPropertyName("precio")]
    public decimal Precio { get; set; }

    [JsonPropertyName("stock")]
    public int Stock { get; set; }

    [JsonPropertyName("marca")]
    public string Marca { get; set; } = "";

    [JsonPropertyName("imagen")]
    public string Imagen { get; set; } = "";

    [JsonPropertyName("estado_stock")]
    public string EstadoStock { get; set; } = "";

    [JsonPropertyName("estado_stock_display")]
    public string EstadoStockDisplay { get; set; } = "";
}