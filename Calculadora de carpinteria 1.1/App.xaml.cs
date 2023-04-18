using Calculadora_de_carpinteria_1._1.Models;
using Calculadora_de_carpinteria_1._1.View;

namespace Calculadora_de_carpinteria_1._1;

public partial class App : Application
{
	public App(ISecureStorageService secureStorage)
	{
		InitializeComponent();
        //MainPage = new NavigationPage(new ValidationView(secureStorage));
        MainPage = new NavigationPage(new MainPage());
    }
}
