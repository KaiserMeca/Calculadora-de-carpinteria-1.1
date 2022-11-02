namespace Calculadora_de_carpinteria_1._1;

public partial class PresupuestoView : ContentPage
{
	public PresupuestoView(List<Abertura> abertura)
	{
		InitializeComponent();
        lista = abertura;
        crearGrid();
    }
    List<Abertura> lista = new List<Abertura>();
    public void crearGrid()
	{
        #region Titles
        ColumnDefinition columnaLinea = new() { Width = 70};
        ColumnDefinition columnaCantidad = new() { Width = 40 };
        ColumnDefinition columnaMedida = new() { Width = 120 };
        ColumnDefinition columnaTipo = new() { Width = 120 };

        Grid title = new Grid();
        title.ColumnDefinitions.Add(columnaLinea);
        title.ColumnDefinitions.Add(columnaCantidad);
        title.ColumnDefinitions.Add(columnaMedida);
        title.ColumnDefinitions.Add(columnaTipo);

        Label labelLinea = new() { FontSize = 14, TextColor = Colors.Black, Text = "Linea"};
        Label labelCantidad = new() { FontSize = 14, TextColor = Colors.Black, Text = "Cant" };
        Label labelMedida = new() { FontSize = 14, TextColor = Colors.Black, Text = "Medida"};
        Label labelTipo = new() { FontSize = 14, TextColor = Colors.Black, Text="Tipo" };

        title.SetColumn(labelLinea, 0);
        title.SetColumn(labelCantidad, 1);
        title.SetColumn(labelMedida, 2);
        title.SetColumn(labelTipo, 3);


        AbsoluteLayout absoluteLayout = new();
        absoluteLayout.Children.Add(title);
        PrincipalAbsoluteLayout.Add(absoluteLayout);
        
        




        //Label lblTitle = new()
        //{
        //    BackgroundColor = Colors.Black,
        //    TextColor = Colors.White,
        //    FontSize = 15,
        //    Text = "Detalles de la abertura",
        //    HorizontalTextAlignment = TextAlignment.Center
        //};
        //title.Children.Add(lblTitle);
        //TitleGrid.Add(title);
        #endregion
        #region Details Title
        Grid detailsTitle = new ();
        #endregion
        foreach (var item in lista)
        {
            
        }
        //    Grid _grid = new Grid();
        //_grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });

        //_grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
        //_grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });



    }
}