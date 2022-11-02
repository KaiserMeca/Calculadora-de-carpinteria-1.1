using System.Collections.ObjectModel;

namespace Calculadora_de_carpinteria_1._1
{
    public class Model
    {
        public ObservableCollection<Abertura> aberturasCollection { get; set; } = new ObservableCollection<Abertura>();

        public void Guardar(Abertura aberturax)
        {
            aberturasCollection.Add(aberturax);
        }
    }
}
