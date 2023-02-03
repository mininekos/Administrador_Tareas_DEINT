using Administrador_Tareas_DEINT.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_Tareas_DEINT.MVVM.ViewModels
{
    public class TareaVM
    {
        public ObservableCollection<Categoria> Categorias { get; set; }
        public ObservableCollection<Tarea> Tareas { get; set; }
        public TareaVM() {
            
            Categorias=new ObservableCollection<Categoria>() { 
                new Categoria{ 
                    Nombre="Curso .NET MAUI",
                    Id=0,
                },
                new Categoria{
                    Nombre="Tutoriales",
                    Id=1,
                },
                new Categoria{
                    Nombre="Compras",
                    Id=2,
                }
            };

            Tareas = new ObservableCollection<Tarea>() {
                new Tarea { 
                    NombreTarea="Actualizar Fichero",
                    Acabada=false,
                    Id_Categoria=0  
                },
                new Tarea {
                    NombreTarea="Planear siguiente curso",
                    Acabada=false,
                    Id_Categoria=0
                },
                new Tarea {
                    NombreTarea="ASP.NET en YouTube",
                    Acabada=false,
                    Id_Categoria=1
                },
                new Tarea {
                    NombreTarea="XAML",
                    Acabada=false,
                    Id_Categoria=1
                },
                new Tarea {
                    NombreTarea="JavaScript",
                    Acabada=false,
                    Id_Categoria=1
                },
            };

            asignarTareas();
        }

        public void asignarTareas() { 
        
            foreach (var categoria in Categorias) {
            
                categoria.ContadorSinAcabar = Tareas.Where(t=> t.Id_Categoria==categoria.Id && !t.Acabada).ToList().Count();
                categoria.ContadorTotal = Tareas.Where(t=> t.Id_Categoria==categoria.Id).ToList().Count();
                categoria.Progress = ((categoria.ContadorTotal- categoria.ContadorSinAcabar) / categoria.ContadorTotal);
            }
        
        }
    }
}
