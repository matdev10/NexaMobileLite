namespace NexaMobileLite.Views.Login;

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
            await DisplayAlert("Bienvenido", "Acceso correcto a Nexa Mobile Lite", "Aceptar");
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "Aceptar");
        }
    }
}