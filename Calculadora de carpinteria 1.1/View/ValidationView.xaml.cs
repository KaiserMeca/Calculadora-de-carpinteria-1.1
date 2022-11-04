using Calculadora_de_carpinteria_1._1.Models;

namespace Calculadora_de_carpinteria_1._1.View;

public partial class ValidationView : ContentPage
{
    KeyTokenList keyTokenList = new();
    private readonly ISecureStorageService SecureStorageServiceIn;
    int claveNumero;
    string claveRecuperada;
    string codigoRecuperado;
    string key = "Tetragramaton";

    public ValidationView(ISecureStorageService secureStorageService)
    {
        InitializeComponent();
        entryClave.Text = "";
        SecureStorageServiceIn = secureStorageService;
        _ = recuperarClave(null);
        //PrincipalPage.IsVisible = false;
    }

    private void Entrar_Clicked(object sender, EventArgs e)
    {
        if (claveRecuperada == entryClave.Text)
        {
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            DisplayAlert("","La clave ingresada es incorrecta","Ok");
        }
    }

    private void GenerarClave_Clicked(object sender, EventArgs e)
    {
        GenerarKeyToken();
        _ = guardarClave(keyTokenList.listaDeClaves[claveNumero].Clave);
        _ = recuperarClave(sender);
        lblMostrarCodigo.Text = codigoRecuperado;
    }
    
    public void GenerarKeyToken()
    {
        Random rnd = new();
        claveNumero = rnd.Next(0, 20);
        var ObjetoDeLaLista = keyTokenList.listaDeClaves[claveNumero];
        codigoRecuperado = ObjetoDeLaLista.Codigo;
    }
    #region SecureStorage
    public async Task guardarClave(string token)
    {
        await SecureStorageServiceIn.Guardar(key, token);
    }

    public async Task recuperarClave(Object button)
    {
        if (button is Button)
        {
            claveRecuperada = await SecureStorageServiceIn.Recuperar(key);
        }
        if (button is null)
        {
            claveRecuperada = await SecureStorageServiceIn.Recuperar(key);
            if (claveRecuperada != null)
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
    private void BorrarClick_Clicked(object sender, EventArgs e)
    {
        BorrarToken();
        DisplayAlert("", "Borrado", "ok");
    }

    public async void BorrarToken()
    { await SecureStorageServiceIn.BorrarClave(key); }
    #endregion
}