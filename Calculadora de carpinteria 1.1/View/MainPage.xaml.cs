﻿using Calculadora_de_carpinteria_1._1.View;

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
}

