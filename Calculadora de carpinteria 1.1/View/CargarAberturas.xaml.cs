using Calculadora_de_carpinteria_1._1.Lineas;
using Microsoft.Maui;
using System.Threading;

namespace Calculadora_de_carpinteria_1._1;

public partial class CargarAberturas : TabbedPage
{
    public CargarAberturas()
    {
        InitializeComponent();
        pickerCantidadSeleccionada.SelectedItem = 1;
        pickerPorcentajeSeleccionado.SelectedItem = 60;
    }
    bool camposValidados = false;
    string IsLinea;
    private Modena modena = new Modena();

    private void BtnAgregarAbertura_Clicked(object sender, EventArgs e)
    {
        //llenarCampos();
        ValidarCampos();
        if (ModenaPage.IsLoaded == true && camposValidados == true)
        {
            IsLinea = "Mod";
            object tipo = pickerAberturaSeleccionada.SelectedItem;
            object cant = pickerCantidadSeleccionada.SelectedItem;
            object porcentaje = pickerPorcentajeSeleccionado.SelectedItem;

            modena.Ventanamodena(IsLinea, Convert.ToString(tipo), Convert.ToDouble(anchoIn.Text), Convert.ToDouble(altoIn.Text),
            Convert.ToDouble(PrecioAluminioIn.Text), Convert.ToDouble(PrecioVidrioIn.Text), Convert.ToDouble(PrecioAccesoriosIn.Text),
            SwitchContramaco.IsToggled, SwitchPremarco.IsToggled, Convert.ToInt32(cant), Convert.ToInt32(porcentaje));

            Navigation.PushAsync(new Presupuesto(modena.aberturaActual));

            deleteLabels();
        }
        if (A30Page.IsLoaded == true)
        {
            IsLinea = "A30";
            object tipo = pickerAberturaSeleccionadaA30.SelectedItem;
            Navigation.PushAsync(new Presupuesto(null));
        }
    }
    private void deleteLabels()
    {
        pickerAberturaSeleccionada.SelectedItem = null;
        altoIn.Text = "";
        anchoIn.Text = "";
    }
    public void ValidarCampos()
    {
        #region Validaciones
        if (pickerAberturaSeleccionada.SelectedItem == null || isInt32(anchoIn.Text) || isInt32(altoIn.Text) || isInt32(PrecioAluminioIn.Text) ||
            isInt32(PrecioVidrioIn.Text) || isInt32(PrecioAccesoriosIn.Text))
        {
            if (pickerAberturaSeleccionada.SelectedItem == null)
            {
                pickerAberturaSeleccionada.FontSize = 10;
                pickerAberturaSeleccionada.TitleColor = Colors.Red;
                pickerAberturaSeleccionada.Title = "**Ingrese el tipo**";
                camposValidados = false;
            }
            if (isInt32(anchoIn.Text))
            {
                anchoIn.FontSize = 10;
                anchoIn.PlaceholderColor = Colors.Red;
                anchoIn.Placeholder = "**Ingrese el ancho**";
                camposValidados = false;
            }
            if (isInt32(altoIn.Text))
            {
                altoIn.FontSize = 10;
                altoIn.PlaceholderColor = Colors.Red;
                altoIn.Placeholder = "**Ingrese el alto**";
                camposValidados = false;
            }

            if (isInt32(PrecioAluminioIn.Text))
            {
                PrecioAluminioIn.FontSize = 10;
                PrecioAluminioIn.PlaceholderColor = Colors.Red;
                PrecioAluminioIn.Placeholder = "**Ingrese el valor**";
                camposValidados = false;
            }
            if (isInt32(PrecioVidrioIn.Text))
            {
                PrecioVidrioIn.FontSize = 10;
                PrecioVidrioIn.PlaceholderColor = Colors.Red;
                PrecioVidrioIn.Placeholder = "**Ingrese el valor**";
                camposValidados = false;
            }
            if (isInt32(PrecioAccesoriosIn.Text))
            {
                PrecioAccesoriosIn.FontSize = 10;
                PrecioAccesoriosIn.PlaceholderColor = Colors.Red;
                PrecioAccesoriosIn.Placeholder = "**Ingrese el valor**";
                camposValidados = false;
            }
        }
        else
        {
            camposValidados = true;
        }
        #endregion
    }
    public bool isInt32(String num)
    {
        try
        {
            Int32.Parse(num);
            return false;
        }
        catch
        {
            return true;
        }
    }

    private void pickerAberturaSeleccionada_Focused(object sender, FocusEventArgs e)
    {
        if (sender is Picker)
        {
            pickerAberturaSeleccionada.FontSize = 14;
            pickerAberturaSeleccionadaA30.FontSize = 14;
        }
        else
        {
            var x = (Entry)sender;
            x.FontSize = 15;
            x.PlaceholderColor = Colors.Transparent;
        }
    }

    public void llenarCampos()
    {
        pickerAberturaSeleccionada.SelectedItem = "Puerta de abrir 2 hojas";
        anchoIn.Text = "2000";
        altoIn.Text = "2000";
        PrecioAluminioIn.Text = "1200";
        PrecioVidrioIn.Text = "3500";
        PrecioAccesoriosIn.Text = "4500";
        pickerCantidadSeleccionada.SelectedItem = 2;


    }
}
