using System.Text.Json;
using NexaMobileLite.Helpers;
using NexaMobileLite.Models;

namespace NexaMobileLite.Services;

public class ClienteService
{
    private readonly HttpClient _httpClient = new();

    public async Task<List<Cliente>> ObtenerClientesAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync(ApiConfig.ClientesUrl);

            if (!response.IsSuccessStatusCode)
                return new List<Cliente>();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Cliente>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<Cliente>();
        }
        catch
        {
            return new List<Cliente>();
        }
    }
}