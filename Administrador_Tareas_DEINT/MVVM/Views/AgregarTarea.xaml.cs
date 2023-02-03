using Administrador_Tareas_DEINT.MVVM.ViewModels;

namespace Administrador_Tareas_DEINT.MVVM.Views;

public partial class AgregarTarea : ContentPage
{
	public AgregarTarea()
	{
		InitializeComponent();
	}

    public AgregarTarea(TareaVM tareaVM)
    {
        InitializeComponent();
        BindingContext= tareaVM;
    }

    private void btnPag3_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }
}