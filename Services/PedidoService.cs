using System.Text.Json;
using NexaMobileLite.Helpers;
using NexaMobileLite.Models;

namespace NexaMobileLite.Services;

public class PedidoService
{
    private readonly HttpClient _httpClient = new();

    public async Task<List<Pedido>> ObtenerPedidosAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync(ApiConfig.PedidosUrl);

            if (!response.IsSuccessStatusCode)
                return new List<Pedido>();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Pedido>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<Pedido>();
        }
        catch
        {
            return new List<Pedido>();
        }
    }
}