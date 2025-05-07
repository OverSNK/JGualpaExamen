namespace JGualpaExamen.Views;

public partial class vLogin : ContentPage
{
    string[] usuarios = { "estudiante2025", "uisrael", "sistemas" };
    string[] claves = { "moviles", "2025", "2025_1" };
    public vLogin()
	{
		InitializeComponent();
	}

    public async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string user = txtUsuario.Text?.Trim();
        string pass = txtContraseña.Text;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (string.Equals(user, usuarios[i], StringComparison.OrdinalIgnoreCase) && pass == claves[i])
            {
                await DisplayAlert("Bienvenido", $"Hola {usuarios[i]}, bienvenido al sistema.", "Aceptar");

                // Abre la ventana principal
                await Navigation.PushAsync(new vRegistro(usuarios[i]));
                return;
            }
        }
        if (string.IsNullOrEmpty(user))
        {
            await DisplayAlert("Error", "Campos vacíos, ingrese un usuario", "Aceptar");
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "Aceptar");
        }
    }
}