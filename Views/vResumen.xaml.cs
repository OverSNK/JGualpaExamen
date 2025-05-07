namespace JGualpaExamen.Views;

public partial class vResumen : ContentPage
{
    public vResumen(string usuario, string nombre, string apellido, string va, DateTime fecha,
                       string ciudad, decimal montoInicial, decimal cuotaMensual)
    {
        InitializeComponent();

        lblUsuario.Text = $"{usuario}";
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblVA.Text = va;
        lblFecha.Text = fecha.ToString("dd/MM/yyyy");
        lblCiudad.Text = ciudad;
        lblMontoInicial.Text = montoInicial.ToString("C2");
        lblCuotaMensual.Text = cuotaMensual.ToString("C2");
        lblPagoTotal.Text = (cuotaMensual * 3 + montoInicial).ToString("C2");
    }

    private async void CerrarSesion_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(); 
    }


}