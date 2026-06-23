namespace NexaMobileLite.Views.Login;
using NexaMobileLite.Views.Dashboard;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void BtnIngresar_Clicked(object sender, EventArgs e)
    {
        string usuario = UsuarioEntry.Text ?? "";
        string password = PasswordEntry.Text ?? "";

        if (usuario == "admin" && password == "1234")
        {
            Application.Current.MainPage = new NavigationPage(new DashboardPage());
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "Aceptar");
        }
    }
}