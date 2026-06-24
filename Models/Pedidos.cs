using System.Text.Json.Serialization;

namespace NexaMobileLite.Models;

public class Pedido
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cliente_nombre")]
    public string ClienteNombre { get; set; } = "";

    [JsonPropertyName("cliente_email")]
    public string ClienteEmail { get; set; } = "";

    [JsonPropertyName("cliente_telefono")]
    public string ClienteTelefono { get; set; } = "";

    [JsonPropertyName("estado")]
    public string Estado { get; set; } = "";

    [JsonPropertyName("estado_texto")]
    public string EstadoTexto { get; set; } = "";

    [JsonPropertyName("metodo_entrega_texto")]
    public string MetodoEntregaTexto { get; set; } = "";

    [JsonPropertyName("estado_pago")]
    public string EstadoPago { get; set; } = "";

    [JsonPropertyName("subtotal")]
    public int Subtotal { get; set; }

    [JsonPropertyName("costo_envio")]
    public int CostoEnvio { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("creado")]
    public string Creado { get; set; } = "";

    [JsonPropertyName("detalles")]
    public List<DetallePedido> Detalles { get; set; } = new();
}

public class DetallePedido
{
    [JsonPropertyName("producto_id")]
    public int ProductoId { get; set; }

    [JsonPropertyName("producto_nombre")]
    public string ProductoNombre { get; set; } = "";

    [JsonPropertyName("cantidad")]
    public int Cantidad { get; set; }

    [JsonPropertyName("precio_unitario")]
    public int PrecioUnitario { get; set; }

    [JsonPropertyName("subtotal")]
    public int Subtotal { get; set; }
}