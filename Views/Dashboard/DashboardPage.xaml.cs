using NexaMobileLite.Views.Clientes;
using NexaMobileLite.Views.Inventario;
using NexaMobileLite.Views.Pedidos;
using NexaMobileLite.Views.Ventas;

namespace NexaMobileLite.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
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