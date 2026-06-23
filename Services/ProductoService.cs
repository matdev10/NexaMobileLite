using System.Text.Json;
using NexaMobileLite.Helpers;
using NexaMobileLite.Models;

namespace NexaMobileLite.Services;

public class ProductoService
{
    private readonly HttpClient _httpClient = new();

    public async Task<List<Producto>> ObtenerProductosAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync(ApiConfig.ProductosUrl);

            if (!response.IsSuccessStatusCode)
                return new List<Producto>();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Producto>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<Producto>();
        }
        catch
        {
            return new List<Producto>();
        }
    }
}