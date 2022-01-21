using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonasU6A2
{
    class AddNacionalidadWindowVM : ObservableObject
    {

        private String nacionalidad;

        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public AddNacionalidadWindowVM()
        {
        }

        internal void Aceptar()
        {
            WeakReferenceMessenger.Default.Send(new NacionalidadCambiadaMessage(Nacionalidad));
        }
    }
}
