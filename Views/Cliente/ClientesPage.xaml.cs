using NexaMobileLite.ViewModels;

namespace NexaMobileLite.Views.Clientes;

public partial class ClientesPage : ContentPage
{
    private readonly ClientesViewModel _viewModel;

    public ClientesPage()
    {
        InitializeComponent();
        _viewModel = (ClientesViewModel)BindingContext;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.CargarClientesAsync();
    }
}