using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_Tareas_DEINT.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    class Tarea
    {
        public string Nombre { get; set; }
        public bool Acabada{ get; set; }

    }
}
