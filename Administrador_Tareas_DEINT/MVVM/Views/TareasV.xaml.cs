namespace Administrador_Tareas_DEINT.MVVM.Views;

public partial class TareasV : ContentPage
{
	public TareasV()
	{
		InitializeComponent();
	}

    private void btnPag2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AgregarTarea());
        
    }
}