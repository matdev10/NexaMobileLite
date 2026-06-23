using System.Collections.ObjectModel;
using System.Windows.Input;
using NexaMobileLite.Models;
using NexaMobileLite.Services;

namespace NexaMobileLite.ViewModels;

public class InventarioViewModel : BaseViewModel
{
    private readonly ProductoService _productoService = new();

    public ObservableCollection<Producto> Productos { get; set; } = new();

    private bool _estaCargando;
    public bool EstaCargando
    {
        get => _estaCargando;
        set => SetProperty(ref _estaCargando, value);
    }

    public ICommand CargarProductosCommand { get; }

    public InventarioViewModel()
    {
        CargarProductosCommand = new Command(async () => await CargarProductosAsync());
    }

    public async Task CargarProductosAsync()
    {
        EstaCargando = true;

        var productos = await _productoService.ObtenerProductosAsync();

        Productos.Clear();

        foreach (var producto in productos)
            Productos.Add(producto);

        EstaCargando = false;
    }
}