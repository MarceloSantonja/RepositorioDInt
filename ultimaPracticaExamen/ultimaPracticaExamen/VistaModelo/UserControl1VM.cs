using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ultimaPracticaExamen.modelo;
using ultimaPracticaExamen.servicio;

namespace ultimaPracticaExamen.VistaModelo
{
    class UserControl1VM :ObservableRecipient
    {
        private Componente componenteSeleccionado;

        public Componente ComponenteSeleccionado
        {
            get { return componenteSeleccionado; }
            set { SetProperty(ref componenteSeleccionado, value); }
        }

        public UserControl1VM()
        {
            WeakReferenceMessenger.Default.Register<ComponenteMessage>(this, (r, m)=>{
                ComponenteSeleccionado = m.Value;
            });
            Console.WriteLine(componenteSeleccionado.Nombre);
        }
    }
}
