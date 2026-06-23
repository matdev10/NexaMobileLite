using System.Text.Json.Serialization;

namespace NexaMobileLite.Models;

public class Venta
{
    [JsonPropertyName("cliente_id")]
    public int ClienteId { get; set; }

    [JsonPropertyName("producto_id")]
    public int ProductoId { get; set; }

    [JsonPropertyName("cantidad")]
    public int Cantidad { get; set; }

    [JsonPropertyName("total")]
    public decimal Total { get; set; }
}