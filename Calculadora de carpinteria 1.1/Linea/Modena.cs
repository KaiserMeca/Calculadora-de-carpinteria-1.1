namespace Calculadora_de_carpinteria_1._1.Lineas
{
    class Modena : Abertura 
    {
        private Model model = new Model();
        public List<Abertura> aberturaActual = new List<Abertura>();

        public void Ventanamodena(string linea, string tipoIn, double ancho, double alto, double Paluminio, double Pvidrio, double Pacc, bool contra,
            bool pre, int cant, int porcentaje)
        {
            Linea = linea;
            Ancho = ancho;
            Alto = alto;
            PrecioAluminio = Paluminio;
            PrecioVidrio = Pvidrio;
            PrecioAccesorios = Pacc;
            Contramarco = contra;
            Premarco = pre;
            Cantidad = cant;
            Porcentaje = porcentaje;
            Abreviaturas(tipoIn);
            despachador(Tipo);
        }

        public void despachador(string tipoDeAbertura)
        {
            switch (tipoDeAbertura)
            {
                case "V.Corrediza":
                    model.Guardar(ventanaCorrediza());
                    break;
                case "P.Balcón":
                    model.Guardar(CorredizaBalcon());
                    break;
                case "V.De abrir":
                    model.Guardar(ventanaRebatible());
                    break;
                case "Banderola":
                    model.Guardar(ventanaRebatible());
                    break;
                case "Desplazable":
                    model.Guardar(ventanaRebatible());
                    break;
                case "P.Abrir":
                    model.Guardar(puertaDeAbrirSimple());
                    break;
                case "P.Abrir2Hojas":
                    model.Guardar(PuertaDeAbrirDoble());
                    break;
                case "Guía triple":
                    model.Guardar(guiaTriple());
                    break;
                case "Paño fijo":
                    model.Guardar(panioFijo());
                    break;
            }
        }
        void Abreviaturas(string TipoDeAberturaAbreviada)
        {
            switch (TipoDeAberturaAbreviada)
            {
                case "Ventana corrediza":
                    {
                        Tipo = "V.Corrediza";
                        break;
                    }
                case "Puerta balcón":
                    {
                        Tipo = "P.Balcón";
                        break;
                    }
                case "Desplazable":
                    {
                        Tipo = "Desplazable";
                        break;
                    }
                case "Banderola":
                    {
                        Tipo = "Banderola";
                        break;
                    }
                case "Ventana de abrir":
                    {
                        Tipo = "V.De abrir";
                        break;
                    }
                case "Puerta de abrir simple":
                    {
                        Tipo = "P.Abrir";
                        break;
                    }
                case "Puerta de abrir 2 hojas":
                    {
                        Tipo = "P.Abrir2Hojas";
                        break;
                    }
                case "Paño fijo":
                    {
                        Tipo = "Paño fijo";
                        break;
                    }
                case "Guía triple":
                    {
                        Tipo = "Guía triple";
                        break;
                    }
            }
        }
        public Abertura Cargar(int Punitario, int PxCant)
        {
            Abertura aberturaNueva = new()
            {
                Linea = Linea,
                Tipo = Tipo,
                Ancho = Ancho,
                Alto = Alto,
                Contramarco = Contramarco,
                Premarco = Premarco,
                Cantidad = Cantidad,
                Porcentaje = Porcentaje,
                PrecioUnitario = Punitario,
                PrecioFinal = PxCant
            };
            aberturaActual.Add(aberturaNueva);
            return aberturaNueva;
        }

        #region ventanaCorrediza
        public Abertura ventanaCorrediza()
        {
            double contramarco = 0;
            if (Contramarco == true)
            {
                contramarco = ((Ancho * 2) + (Alto * 2)) / 1000 * p206;
            }
            double kg200 = ((Ancho * 2) / 1000) * p200;
            double kg201 = ((Alto * 2) / 1000) * p201;
            double kg203 = (((Alto - 50) * 2) / 1000) * p203;
            double kg207 = (((Alto - 50) * 2) / 1000) * p207;
            double kg204 = ((Ancho * 2) / 1000) * p204;
            double AluminioTotal = (kg200 + kg201 + kg203 + kg204 + kg207 + contramarco) * PrecioAluminio;

            double vidrioTotal = ((Ancho / 1000) * (Alto / 1000)) * PrecioVidrio;

            double manoDeObra = ((AluminioTotal + vidrioTotal + PrecioAccesorios) * Porcentaje) / 100;

            int precioUnitario = Convert.ToInt32(AluminioTotal + vidrioTotal + PrecioAccesorios + manoDeObra);
            int precioXcant = precioUnitario * Cantidad;

            return Cargar(precioUnitario, precioXcant);
        }
        #endregion
        #region CorredizaBalcon
        public Abertura CorredizaBalcon()
        {
            double contramarco = 0;
            if (Contramarco == true)
            {
                contramarco = (Ancho + (Alto * 2)) / 1000 * p206;
            }
            double kg200 = ((Ancho * 2) / 1000) * p200;
            double kg201 = ((Alto * 2) / 1000) * p201;
            double kg203 = (((Alto - 50) * 2) / 1000) * p203;
            double kg207 = (((Alto - 50) * 2) / 1000) * p207;
            double kg204 = (Ancho / 1000) * p204;
            double kg209 = (Ancho / 1000) * p209;
            double AluminioTotal = (kg200 + kg201 + kg203 + kg204 + kg207 + kg209 + contramarco) * PrecioAluminio;

            double vidrioTotal = ((Ancho / 1000) * (Alto / 1000)) * PrecioVidrio;

            double manoDeObra = ((AluminioTotal + vidrioTotal + PrecioAccesorios) * Porcentaje) / 100;

            int precioUnitario = Convert.ToInt32(AluminioTotal + vidrioTotal + PrecioAccesorios + manoDeObra);
            int precioXcant = precioUnitario * Cantidad;

            return Cargar(precioUnitario, precioXcant);
        }
        #endregion
        #region ventanaRebatible
        public Abertura ventanaRebatible()
        {
            double contramarco = 0;
            if (Contramarco == true)
            {
                contramarco = ((Ancho * 2) + (Alto * 2)) / 1000 * p206;
            }
            double kg216 = (((Ancho * 2) / 1000) + ((Alto * 2) / 1000)) * p216;
            double kg235 = (((Ancho * 2) / 1000) + ((Alto * 2) / 1000)) * p235;
            double kg230 = (((Ancho * 2) / 1000) + ((Alto * 2) / 1000)) * p230;

            double AluminioTotal = (kg216 + kg235 + kg230 + contramarco) * PrecioAluminio;

            double vidrioTotal = ((Ancho / 1000) * (Alto / 1000)) * PrecioVidrio;

            double manoDeObra = ((AluminioTotal + vidrioTotal + PrecioAccesorios) * Porcentaje) / 100;

            int precioUnitario = Convert.ToInt32(AluminioTotal + vidrioTotal + PrecioAccesorios + manoDeObra);
            int precioXcant = precioUnitario * Cantidad;
            return Cargar(precioUnitario, precioXcant);
        }
        #endregion
        #region puertaDeAbrirSimple
        public Abertura puertaDeAbrirSimple()
        {
            double contramarco = 0;
            if (Contramarco == true)
            {
                contramarco = (Ancho + (Alto * 2)) / 1000 * p206;
            }
            double kg216 = ((Ancho / 1000) + ((Alto * 2) / 1000)) * p216;
            double kg214 = ((Ancho / 1000) + ((Alto * 2) / 1000)) * p214;
            double kg230 = (((Ancho * 2) / 1000) + ((Alto * 2) / 1000)) * p230;
            double kg237 = (((Ancho * 2) / 1000) + ((Alto * 2) / 1000)) * p237;
            double kg219 = (Ancho / 1000) * p219;

            double AluminioTotal = (kg216 + kg214 + kg230 + kg237 + kg219 + contramarco) * PrecioAluminio;

            double vidrioTotal = ((Ancho / 1000) * (Alto / 1000)) * PrecioVidrio;

            double manoDeObra = ((AluminioTotal + vidrioTotal + PrecioAccesorios) * Porcentaje) / 100;

            int precioUnitario = Convert.ToInt32(AluminioTotal + vidrioTotal + PrecioAccesorios + manoDeObra);
            int precioXcant = precioUnitario * Cantidad;
            return Cargar(precioUnitario, precioXcant);
        }
        #endregion
        #region PuertaDeAbrirDoble
        public Abertura PuertaDeAbrirDoble()
        {
            double contramarco = 0;
            if (Contramarco == true)
            {
                contramarco = (Ancho + (Alto * 2)) / 1000 * p206;
            }
            double kg216 = ((Ancho / 1000) + ((Alto * 2) / 1000)) * p216;
            double kg214 = ((Ancho / 1000) + ((Alto * 4) / 1000)) * p214;
            double kg230 = (((Ancho * 2) / 1000) + ((Alto * 4) / 1000)) * p230;
            double kg237 = (((Ancho * 2) / 1000) + ((Alto * 4) / 1000)) * p237;
            double kg219 = (Ancho / 1000) * p219;
            double kg224 = (Alto / 1000) * p224;

            double AluminioTotal = (kg216 + kg214 + kg230 + kg237 + kg219 + kg224 + contramarco) * PrecioAluminio;

            double vidrioTotal = ((Ancho / 1000) * (Alto / 1000)) * PrecioVidrio;

            double manoDeObra = ((AluminioTotal + vidrioTotal + PrecioAccesorios) * Porcentaje) / 100;

            int precioUnitario = Convert.ToInt32(AluminioTotal + vidrioTotal + PrecioAccesorios + manoDeObra);
            int precioXcant = precioUnitario * Cantidad;
            return Cargar(precioUnitario, precioXcant);
        }
        #endregion
        #region guiaTriple
        public Abertura guiaTriple()
        {
            double contramarco = 0;
            if (Contramarco == true)
            {
                contramarco = (Ancho + (Alto * 2)) / 1000 * p206;
            }
            double kg240 = ((Ancho * 2) / 1000) * p240;
            double kg241 = ((Alto * 2) / 1000) * p241;
            double kg203 = (((Alto - 50) * 2) / 1000) * p203;
            double kg207 = (((Alto - 50) * 4) / 1000) * p207;
            double kg204 = (Ancho / 1000) * p204;
            double kg209 = (Ancho / 1000) * p209;
            double AluminioTotal = (kg240 + kg241 + kg203 + kg204 + kg207 + kg209 + contramarco) * PrecioAluminio;

            double vidrioTotal = ((Ancho / 1000) * (Alto / 1000)) * PrecioVidrio;

            double manoDeObra = ((AluminioTotal + vidrioTotal + PrecioAccesorios) * Porcentaje) / 100;

            int precioUnitario = Convert.ToInt32(AluminioTotal + vidrioTotal + PrecioAccesorios + manoDeObra);
            int precioXcant = precioUnitario * Cantidad;

            return Cargar(precioUnitario, precioXcant);
        }
        #endregion
        #region pañoFijo
        public Abertura panioFijo()
        {
            double contramarco = 0;
            if (Contramarco == true)
            {
                contramarco = ((Ancho * 2) + (Alto * 2)) / 1000 * p206;
            }
            double kg216 = (((Ancho * 2) / 1000) + ((Alto * 2) / 1000)) * p216;
            double kg230 = (((Ancho * 2) / 1000) + ((Alto * 2) / 1000)) * p230;

            double AluminioTotal = (kg216 + kg230 + contramarco) * PrecioAluminio;

            double vidrioTotal = ((Ancho / 1000) * (Alto / 1000)) * PrecioVidrio;

            double manoDeObra = ((AluminioTotal + vidrioTotal + PrecioAccesorios) * Porcentaje) / 100;

            int precioUnitario = Convert.ToInt32(AluminioTotal + vidrioTotal + PrecioAccesorios + manoDeObra);
            int precioXcant = precioUnitario * Cantidad;
            return Cargar(precioUnitario, precioXcant);
        }
        #endregion

        double p200 = 1.25;
        double p201 = 0.60;
        double p203 = 0.65;
        double p207 = 0.6;
        double p204 = 0.65;
        double p209 = 1.3;
        double p206 = 0.19;
        double p216 = 0.75;
        //double p221 = 0.8;//travesaño pf
        double p235 = 0.9;
        double p214 = 1.08;
        //double p218 = 1.2;
        double p219 = 1.54;
        double p224 = 0.8;//encuentro puerta dos hojas
        double p240 = 1.823;//guia triple
        double p241 = 0.975;//jamba guia triple;
        double p230 = 0.2;
        double p237 = 0.2;
    }
}
