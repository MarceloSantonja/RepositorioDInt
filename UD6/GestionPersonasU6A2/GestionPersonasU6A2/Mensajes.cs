using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonasU6A2
{
    public class PersonaActualRequestMessage : RequestMessage<Persona> { }

    public class NacionalidadCambiadaMessage : ValueChangedMessage<String>
    {
        public NacionalidadCambiadaMessage(String valor) : base(valor) { }
    }

    public class NuevaPersonaMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaMessage(Persona persona) : base(persona) { }
    }


}
