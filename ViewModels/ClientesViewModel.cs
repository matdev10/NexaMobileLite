using System.Collections.ObjectModel;
using NexaMobileLite.Models;
using NexaMobileLite.Services;

namespace NexaMobileLite.ViewModels;

public class ClientesViewModel : BaseViewModel
{
    private readonly ClienteService _clienteService = new();

    public ObservableCollection<Cliente> Clientes { get; set; } = new();

    private bool _estaCargando;
    public bool EstaCargando
    {
        get => _estaCargando;
        set => SetProperty(ref _estaCargando, value);
    }

    public async Task CargarClientesAsync()
    {
        EstaCargando = true;

        var clientes = await _clienteService.ObtenerClientesAsync();

        Clientes.Clear();

        foreach (var cliente in clientes)
            Clientes.Add(cliente);

        EstaCargando = false;
    }

    public async Task<bool> CrearClienteAsync(Cliente cliente)
    {
        EstaCargando = true;

        var creado = await _clienteService.CrearClienteAsync(cliente);

        if (creado)
            await CargarClientesAsync();

        EstaCargando = false;

        return creado;
    }
}