using Administrador_Tareas_DEINT.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_Tareas_DEINT.MVVM.ViewModels
{
    internal class TareaVM
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
                    Nombre="Actualizar Fichero",
                    Acabada=false,
                    Id_Categoria=0  
                },
                new Tarea {
                    Nombre="Planear siguiente curso",
                    Acabada=false,
                    Id_Categoria=0
                },
                new Tarea {
                    Nombre="ASP.NET en YouTube",
                    Acabada=false,
                    Id_Categoria=0
                },
                new Tarea {
                    Nombre="XAML",
                    Acabada=false,
                    Id_Categoria=0
                },
                new Tarea {
                    Nombre="JavaScript",
                    Acabada=false,
                    Id_Categoria=0
                },

            };

        
        }
    }
}
