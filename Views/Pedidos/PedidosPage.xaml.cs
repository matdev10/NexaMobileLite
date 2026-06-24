using System.Collections.ObjectModel;
using NexaMobileLite.Models;
using NexaMobileLite.Services;

namespace NexaMobileLite.Views.Pedidos;

public partial class PedidosPage : ContentPage
{
    private readonly PedidoService _pedidoService = new();

    public ObservableCollection<Pedido> Pedidos { get; set; } = new();

    public PedidosPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await CargarPedidosAsync();
    }

    private async Task CargarPedidosAsync()
    {
        Pedidos.Clear();

        var pedidos = await _pedidoService.ObtenerPedidosAsync();

        foreach (var pedido in pedidos)
        {
            Pedidos.Add(pedido);
        }
    }
}