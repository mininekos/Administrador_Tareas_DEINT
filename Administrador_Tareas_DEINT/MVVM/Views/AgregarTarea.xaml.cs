namespace Administrador_Tareas_DEINT.MVVM.Views;

public partial class AgregarTarea : ContentPage
{
	public AgregarTarea()
	{
		InitializeComponent();
	}

    private void btnPag2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AgregarCategoria());

    }

    private void btnPag3_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }
}