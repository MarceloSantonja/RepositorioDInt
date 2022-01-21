using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonasU6A2
{
    class UserControlConsultaPersonaVM :ObservableRecipient
    {
        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }
        
        public UserControlConsultaPersonaVM()
        {
            Persona = WeakReferenceMessenger.Default.Send<PersonaActualRequestMessage>();
        }
    }
}
