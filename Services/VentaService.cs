using System.Text;
using System.Text.Json;
using NexaMobileLite.Helpers;
using NexaMobileLite.Models;

namespace NexaMobileLite.Services;

public class VentaService
{
    private readonly HttpClient _httpClient = new();

    public async Task<bool> RegistrarVentaAsync(Venta venta)
    {
        try
        {
            var json = JsonSerializer.Serialize(venta);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(ApiConfig.VentasUrl, content);

            return response.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
    }
}