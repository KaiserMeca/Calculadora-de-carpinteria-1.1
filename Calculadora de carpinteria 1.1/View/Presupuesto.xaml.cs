
using Calculadora_de_carpinteria_1._1.Lineas;
using System.Collections.ObjectModel;

namespace Calculadora_de_carpinteria_1._1;

public partial class Presupuesto : ContentPage
{
    public Presupuesto(ObservableCollection<Abertura> abertura)
    {
        BindingContext = this;
        lista = abertura;
        InitializeComponent();
        cargarFecha();
        PresupuestoTotal();
    }
    public ObservableCollection<Abertura> lista { get; set; } = new ObservableCollection<Abertura>();

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

    private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        string action = await DisplayActionSheet("¿Qué deseas hacer?", "Salir", null, "Editar tipo de abertura", "Editar cantidad",
            "Editar precio unitario", "Eliminar abertura");
        var abertura = (Abertura)ListViewPpal.SelectedItem;
        int aberturaIndex = lista.IndexOf(abertura);
        switch (action)
        {
            case "Editar tipo de abertura":
                string result1 = await DisplayActionSheet("Seleccionar tipo", "Atrás", null, "V.Corrediza", "P.Balcón", "V.De abrir",
                "Banderola", "Desplazable", "P.Abrir", "P.Abrir2Hojas", "Guía triple", "Paño fijo");
                if (!string.IsNullOrWhiteSpace(result1) || result1 == "Atras")
                {
                    abertura.Tipo = result1;
                    Modena Vmodena = new();
                    Vmodena.VentanaModena(abertura, result1);
                    abertura = Vmodena.VentanaParaPresu;
                    lista.Insert(aberturaIndex, abertura);
                    lista.RemoveAt(aberturaIndex + 1);
                    PresupuestoTotal();
                }
                break;
            case "Editar cantidad":
                string result2 = await DisplayPromptAsync("Nueva cantidad", Convert.ToString(abertura.Cantidad), "Confirmar", "Atrás");
                if (!string.IsNullOrWhiteSpace(result2) || result2 == "Atras")
                {
                    abertura.Cantidad = int.Parse(result2);
                    abertura.PrecioFinal = abertura.PrecioUnitario * Convert.ToInt32(result2);
                    lista.Insert(aberturaIndex, abertura);
                    lista.RemoveAt(aberturaIndex + 1);
                    PresupuestoTotal();
                }
                break;
            case "Editar precio unitario":
                string result3 = await DisplayPromptAsync("Nuevo precio unitario", Convert.ToString(abertura.PrecioUnitario), "Confirmar", "Atrás");
                if (!string.IsNullOrWhiteSpace(result3) || result3 == "Atras")
                {
                    abertura.PrecioUnitario = int.Parse(result3);
                    abertura.PrecioFinal = int.Parse(result3) * abertura.Cantidad;
                    lista.Insert(aberturaIndex, abertura);
                    lista.RemoveAt(aberturaIndex + 1);
                    PresupuestoTotal();
                }
                break;

            case "Eliminar abertura":
                bool t = await DisplayAlert("", "¿Estás seguro que deseas eliminar esta abertura?", "Confirmar", "Atrás");
                if (t == true)
                {
                    var z = ListViewPpal.SelectedItem;
                    lista.Remove((Abertura)z);
                    PresupuestoTotal();
                }
                break;
        }
    }
    void PresupuestoTotal()
    {
        int precioTotal = 0;
        foreach (var item in lista)
        {
            precioTotal += item.PrecioFinal;
            EntryPrecioFinal.Text = "$" + Convert.ToString(precioTotal);
        }
    }
}