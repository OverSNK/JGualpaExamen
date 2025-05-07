namespace JGualpaExamen.Views;

public partial class vRegistro : ContentPage
{
    private decimal costoUPS = 300;
    private decimal montoInicialPorcentaje = 0.15m;
    private decimal incrementoPorcentaje = 0.05m;

    public vRegistro()
	{
		InitializeComponent();
	}
    public vRegistro(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = $"Usuario conectado: {usuario}";
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        decimal MontoInicial = costoUPS * montoInicialPorcentaje;
        decimal saldoRestante = costoUPS - MontoInicial;
        decimal incrementoPorCuota = costoUPS * incrementoPorcentaje;
        decimal ValorCuota = (decimal)((saldoRestante / 3) + incrementoPorCuota);
        txtPagoMensual.Text = ValorCuota.ToString();

    }

}