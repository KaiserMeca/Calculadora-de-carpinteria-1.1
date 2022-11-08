namespace Calculadora_de_carpinteria_1._1
{
    public class Abertura
    {
        public Abertura()
        {

        }

        string _linea;
        string _tipo;
        double _alto;
        double _ancho;

        double _precioAluminio;
        double _precioVidrio;
        double _precioAccesorios;

        bool _contramarco;
        bool _premarco;

        int _cantidad;
        int _porcentaje;

        int _precioUnitario;
        int _precioFinal;

        public string Linea { get => _linea; set => _linea = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public double Alto { get => _alto; set => _alto = value; }
        public double Ancho { get => _ancho; set => _ancho = value; }
        public double PrecioAluminio { get => _precioAluminio; set => _precioAluminio = value; }
        public double PrecioVidrio { get => _precioVidrio; set => _precioVidrio = value; }
        public double PrecioAccesorios { get => _precioAccesorios; set => _precioAccesorios = value; }
        public bool Contramarco { get => _contramarco; set => _contramarco = value; }
        public bool Premarco { get => _premarco; set => _premarco = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Porcentaje { get => _porcentaje; set => _porcentaje = value; }
        public int PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }
        public int PrecioFinal { get => _precioFinal; set => _precioFinal = value; }
        public string Medidas
        {
            get { return string.Format("{0}x{1}", Ancho, Alto); }
        }

    }
}
