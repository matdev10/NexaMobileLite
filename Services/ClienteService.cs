using System.Text;
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

    public async Task<bool> CrearClienteAsync(Cliente cliente)
    {
        try
        {
            var data = new
            {
                numero_documento = cliente.Rut,
                nombre = cliente.Nombre,
                apellido = cliente.Apellido,
                rut = cliente.Rut,
                email = cliente.Email,
                telefono = cliente.Telefono,
                direccion = "",
                numero = "",
                comuna = "",
                departamento = "",
                informacion_adicional = ""
            };

            var json = JsonSerializer.Serialize(data);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PostAsync(
                ApiConfig.CrearClienteUrl,
                content
            );

            return response.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
    }
}