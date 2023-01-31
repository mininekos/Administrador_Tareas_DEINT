using Administrador_Tareas_DEINT.MVVM.Views;

namespace Administrador_Tareas_DEINT;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new TareasV());
	}
}
