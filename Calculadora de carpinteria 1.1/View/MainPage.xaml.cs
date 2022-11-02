using Calculadora_de_carpinteria_1._1.View;

namespace Calculadora_de_carpinteria_1._1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CargarAberturas());
    }

    private void BtnCargarPrecios_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Proximamente","Pronto vas a poder guardar los precios del aluminio y de los vidrios!","Genial!");
    }
    public void Line()
    {
        //var dispatcher = Application.Current.Dispatcher; // if your context isn't a BindableObject (if your context is a BO then just this.Dispatcher...)
        //var timer = dispatcher.CreateTimer();
        //timer.Interval = TimeSpan.FromSeconds(1);
        //timer.Tick += (s, e) => this.DateTime = DateTime.Now;
        //timer.Start();
    }
}

