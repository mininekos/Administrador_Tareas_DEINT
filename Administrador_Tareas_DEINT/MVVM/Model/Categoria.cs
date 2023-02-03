using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_Tareas_DEINT.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    class Categoria
    {
        public string Nombre{ get; set; }
        public int Id { get; set; }
        public double ContadorSinAcabar { get; set; }
        public double ContadorTotal { get; set; }
        public double Progress { get; set; }
    }
}
