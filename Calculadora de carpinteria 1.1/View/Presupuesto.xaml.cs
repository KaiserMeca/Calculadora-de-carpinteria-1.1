  
namespace Calculadora_de_carpinteria_1._1;

public partial class Presupuesto : ContentPage
{
    public Presupuesto(List<Abertura> abertura)
    {
        BindingContext = this;
        lista = abertura;
        InitializeComponent();
        cargarFecha();
        //cargarPresupuesto();
    }
    public List<Abertura> lista { get; set; } = new List<Abertura>();
    //public double spacio = 115;
    //string lineaAbreviatura;
    //string tipoAbreviatura;
    public void cargarFecha()
    {
        var c = DateTime.Now.ToString("d");
        entryFecha.Text = Convert.ToString(c);
    }
    private void BtnNuevaAbertura_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void BtnFinalizarPresu_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("", "¿Esta seguro que desea finalizar el presupuesto?", "Confirmar", "Cancelar", FlowDirection.MatchParent);
    }

}