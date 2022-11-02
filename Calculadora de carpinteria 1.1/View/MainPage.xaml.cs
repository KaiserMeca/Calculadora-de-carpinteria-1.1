using Calculadora_de_carpinteria_1._1.View;

namespace Calculadora_de_carpinteria_1._1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Line();
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
        int count = 0;
        double coun2 = 0;
        var dispatcher = Application.Current.Dispatcher; 
        var timer = dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromMilliseconds(1);
        timer.Tick += (s, e) =>
        {
            count += 1;
            Linea1.Rotation = count;
            Linea2.Rotation = count;
            Linea3.Rotation = count;
            if (count == 90)
            {
                timer.Stop();
            }
            coun2 += 3.66;
            Linea1.Margin = new Thickness(0,0,coun2,0);
            Linea2.Margin = new Thickness(0, 0, coun2, 0);
            Linea3.Margin = new Thickness(0, 0, coun2, 0);

        };
        timer.Start();
    }
}

