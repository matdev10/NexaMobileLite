using System.Text.Json.Serialization;

namespace NexaMobileLite.Models;

public class Cliente
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nombre")]
    public string Nombre { get; set; } = "";

    [JsonPropertyName("apellido")]
    public string Apellido { get; set; } = "";

    [JsonPropertyName("rut")]
    public string Rut { get; set; } = "";

    [JsonPropertyName("email")]
    public string Email { get; set; } = "";

    [JsonPropertyName("telefono")]
    public string Telefono { get; set; } = "";

    public string NombreCompleto => $"{Nombre} {Apellido}".Trim();
}