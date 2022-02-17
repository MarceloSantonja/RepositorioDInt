using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using segundaPraticaExamenFinal.modelo;
using segundaPraticaExamenFinal.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaPraticaExamenFinal.vistamodelo
{
    class InfoUserControlVM: ObservableRecipient
    {

        private Componente componenteSeleccionado;

        public Componente ComponenteSeleccionado
        {
            get { return componenteSeleccionado; }
            set { SetProperty(ref componenteSeleccionado, value); }
        }

        public InfoUserControlVM()
        {
            componenteSeleccionado = WeakReferenceMessenger.Default.Send<ComponenteRequestMessage>();
        }
    }
}
