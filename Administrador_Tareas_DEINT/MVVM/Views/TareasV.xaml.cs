using Administrador_Tareas_DEINT.MVVM.ViewModels;

namespace Administrador_Tareas_DEINT.MVVM.Views;

public partial class TareasV : ContentPage
{
	public TareasV()
	{
		InitializeComponent();
        BindingContext = new TareaVM();
	}

    private void btnAgregarTarea_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AgregarTarea());
    }
}