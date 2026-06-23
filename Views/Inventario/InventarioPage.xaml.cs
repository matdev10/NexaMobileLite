using NexaMobileLite.ViewModels;

namespace NexaMobileLite.Views.Inventario;

public partial class InventarioPage : ContentPage
{
    private readonly InventarioViewModel _viewModel;

    public InventarioPage()
    {
        InitializeComponent();
        _viewModel = (InventarioViewModel)BindingContext;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.CargarProductosAsync();
    }
}