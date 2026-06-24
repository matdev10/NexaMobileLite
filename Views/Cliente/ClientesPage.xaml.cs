using NexaMobileLite.Models;
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

    private async void BtnNuevoCliente_Clicked(object sender, EventArgs e)
    {
        string nombre = await DisplayPromptAsync("Nuevo cliente", "Nombre:");
        if (string.IsNullOrWhiteSpace(nombre)) return;

        string apellido = await DisplayPromptAsync("Nuevo cliente", "Apellido:");
        if (string.IsNullOrWhiteSpace(apellido)) return;

        string rut = await DisplayPromptAsync("Nuevo cliente", "RUT:");
        if (string.IsNullOrWhiteSpace(rut)) return;

        string email = await DisplayPromptAsync("Nuevo cliente", "Email:");
        string telefono = await DisplayPromptAsync("Nuevo cliente", "Teléfono:");

        var cliente = new Cliente
        {
            Nombre = nombre,
            Apellido = apellido,
            Rut = rut,
            Email = email ?? "",
            Telefono = telefono ?? ""
        };

        var creado = await _viewModel.CrearClienteAsync(cliente);

        if (creado)
            await DisplayAlert("Correcto", "Cliente creado correctamente", "Aceptar");
        else
            await DisplayAlert("Error", "No se pudo crear el cliente", "Aceptar");
    }
}