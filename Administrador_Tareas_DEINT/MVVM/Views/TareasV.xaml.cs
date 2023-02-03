using Administrador_Tareas_DEINT.MVVM.Model;
using Administrador_Tareas_DEINT.MVVM.ViewModels;

namespace Administrador_Tareas_DEINT.MVVM.Views;

public partial class TareasV : ContentPage
{
    TareaVM tareaVM;
	public TareasV()
    {
        tareaVM = new TareaVM();
		InitializeComponent();
        BindingContext = tareaVM;
	}

    private void btnAgregarTarea_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AgregarTarea(tareaVM));
    }
    private void checkBox_CheckedChanged(object sender, EventArgs e)
    {
        tareaVM.asignarTareas();
    }
}