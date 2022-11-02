  
namespace Calculadora_de_carpinteria_1._1;

public partial class Presupuesto : ContentPage
{
    public Presupuesto(List<Abertura> abertura)
    {
        InitializeComponent();
        //BindingContext = abertura;
        lista = abertura;
        cargarFecha();
        cargarPresupuesto();
    }
    List<Abertura> lista = new List<Abertura>();
    public double spacio = 115;
    string lineaAbreviatura;
    string tipoAbreviatura;
    public void cargarPresupuesto()
    {
        foreach (var item in lista)
        {
            Abreviaturas(item.Linea, item.Tipo);
            spacio += 20;
            AbsoluteLayout stackLayout = new AbsoluteLayout
            {
                Margin = new Thickness(5, spacio, 0, 0),
                Children =
                {
                    new HorizontalStackLayout
                    {
                        Children =
                        {
                            new Editor
                            {
                                TextColor = Colors.Black,
                                Text = tipoAbreviatura + "-" + lineaAbreviatura,
                                FontSize = 11,
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.Center,
                                WidthRequest = 125,
                                HorizontalTextAlignment = TextAlignment.Center,
                                Margin = new Thickness(8,0,0,0)
                            },
                            new Editor
                            {
                                TextColor = Colors.Black,
                                Text = item.Ancho.ToString() + "x" + item.Alto.ToString(),
                                FontSize = 11,
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.Center,
                                WidthRequest = 100,
                                HorizontalTextAlignment = TextAlignment.Center,
                                Margin = new Thickness(4,0,0,0)
                            },
                            new Editor
                            {
                                TextColor = Colors.Black,
                                Text = item.Cantidad.ToString(),
                                FontSize = 11,
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.Center,
                                WidthRequest = 24,
                                HorizontalTextAlignment = TextAlignment.Center
                            },
                            new Editor
                            {
                                TextColor = Colors.Black,
                                Text = item.PrecioUnitario.ToString(),
                                FontSize = 11,
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.Center,
                                WidthRequest = 75,
                                HorizontalTextAlignment = TextAlignment.Center,
                                Margin = new Thickness(6,0,0,0)
                            },
                            new Editor
                            {
                                TextColor = Colors.Black,
                                Text = item.PrecioFinal.ToString(),
                                FontSize = 11,
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.Center,
                                WidthRequest = 75,
                                HorizontalTextAlignment = TextAlignment.Center,
                                Margin = new Thickness(-10,0,0,0)
                            }
                        }
                    },

                }
            };
            layoutPrincipal.Add(stackLayout);
        }
    }
    public void Abreviaturas(string Linea, string Tipo)
    {
        #region Abreviaturas
        switch (Linea)
        {
            case "Modena":
                {
                    lineaAbreviatura = "Mod";
                    break;
                }
            case "A30":
                {
                    lineaAbreviatura = "A30";
                    break;
                }
        }
        switch(Tipo)
        {
            case "Ventana Corrediza":
                {
                    tipoAbreviatura = "V.Corrediza";
                    break;
                }
            case "Puerta balcón":
                {
                    tipoAbreviatura = "P.Balcón";
                    break;
                }
            case "Desplazable":
                {
                    tipoAbreviatura = "Desplazable";
                    break;
                }
            case "Banderola":
                {
                    tipoAbreviatura = "Banderola";
                    break;
                }
            case "Ventana de abrir":
                {
                    tipoAbreviatura = "V.De abrir";
                    break;
                }
            case "Puerta de abrir simple":
                {
                    tipoAbreviatura = "P.Abrir";
                    break;
                }
            case "Puerta de abrir 2 hojas":
                {
                    tipoAbreviatura = "P.Abrir2Hojas";
                    break;
                }
            case "Paño fijo":
                {
                    tipoAbreviatura = "Paño fijo";
                    break;
                }
            case "Guía triple":
                {
                    tipoAbreviatura = "Guía triple";
                    break;
                }
        }
        #endregion
    }

    private void BtnNuevaAbertura_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void BtnFinalizarPresu_Clicked(object sender, EventArgs e)
    {

    }
    public void cargarFecha()
    {
        var c = DateTime.Now;
        entryFecha.Text = Convert.ToString(c);
    }
}