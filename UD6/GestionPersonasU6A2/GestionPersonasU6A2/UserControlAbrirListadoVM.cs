using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonasU6A2
{
    class UserControlAbrirListadoVM : ObservableObject
    {

        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        private ObservableCollection<Persona> personas;

        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set {SetProperty(ref personas , value); }
        }

        private DatosBaseService ServicioPersonas { get; }

        public UserControlAbrirListadoVM()
        {
            ServicioPersonas = new DatosBaseService();
            Personas = ServicioPersonas.GetSamples();
            WeakReferenceMessenger.Default.Register<UserControlAbrirListadoVM, PersonaActualRequestMessage>(this, (r, m)=>{
                m.Reply(r.personaSeleccionada);
            });
            //WeakReferenceMessenger.Default.Register<UserControlAbrirListadoVM, PersonaSeleccionadaMessage>(this, (r, m) =>
            //{
            //    if (!m.HasReceivedResponse)
            //        m.Reply(PersonaSeleccionada);
            //});


        }
    }
}
