using Administrador_Tareas_DEINT.MVVM.Model;
using Administrador_Tareas_DEINT.MVVM.ViewModels;

namespace Administrador_Tareas_DEINT.MVVM.Views;

public partial class AgregarTarea : ContentPage
{
    TareaVM tareaVM;
    int idCategoria;
	public AgregarTarea()
	{
		InitializeComponent();
	}

    public AgregarTarea(TareaVM tareaVM)
    {
        InitializeComponent();
        this.tareaVM = tareaVM;
        BindingContext= tareaVM;
        idCategoria= -1;
    }

    private void btnPag3_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }

    private void addTarea_Clicked(object sender, EventArgs e)
    {
        tareaVM.Tareas.Add(new Tarea()
        {
            NombreTarea = entryTarea.Text,
            Acabada = false,
            Id_Categoria = 1
        });
    }

    private async void addCategoria_ClickedAsync(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("Nueva categoria", "Nombre: ");

        if (result!=null)
        {
            tareaVM.Categorias.Add(new Categoria() { 
                Nombre=result,
                Id=tareaVM.Categorias.Count,
            });
        }
        else { 
            
        }

    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {   
        //RadioButton rd= (RadioButton)sender;
        //idCategoria = Int64.Parse(rd.GetValue());
        
    }
}