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
        public TareaVM() {
        
            
        
        }
    }
}
