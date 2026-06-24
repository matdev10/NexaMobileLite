using NexaMobileLite.Services;
using NexaMobileLite.Views.Clientes;
using NexaMobileLite.Views.Inventario;
using NexaMobileLite.Views.Pedidos;
using NexaMobileLite.Views.Ventas;

namespace NexaMobileLite.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
    private readonly ProductoService _productoService = new();
    private readonly ClienteService _clienteService = new();
    private readonly PedidoService _pedidoService = new();

    public DashboardPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await CargarResumenAsync();
    }

    private async Task CargarResumenAsync()
    {
        var productos = await _productoService.ObtenerProductosAsync();
        var clientes = await _clienteService.ObtenerClientesAsync();
        var pedidos = await _pedidoService.ObtenerPedidosAsync();

        // Inventario
        LblInventario.Text = productos.Count.ToString();

        // Clientes
        LblClientes.Text = clientes.Count.ToString();

        // Pedidos pendientes
        LblPedidos.Text = pedidos
            .Count(p => p.Estado == "PENDIENTE_PAGO")
            .ToString();

        // Stock bajo (según la lógica del servidor)
        LblStockBajo.Text = productos
            .Count(p => p.EstadoStock == "STOCK_BAJO")
            .ToString();
    }

    private async void BtnInventario_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InventarioPage());
    }

    private async void BtnClientes_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientesPage());
    }

    private async void BtnVentas_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VentasPage());
    }

    private async void BtnPedidos_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PedidosPage());
    }
}