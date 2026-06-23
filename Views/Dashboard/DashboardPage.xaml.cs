using NexaMobileLite.Views.Inventario;

namespace NexaMobileLite.Views.Dashboard;
using NexaMobileLite.Views.Clientes;
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
}