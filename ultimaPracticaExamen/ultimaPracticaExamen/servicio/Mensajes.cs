using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ultimaPracticaExamen.modelo;

namespace ultimaPracticaExamen.servicio
{
    class ComponenteMessage : ValueChangedMessage<Componente>
    {
        public ComponenteMessage(Componente componente) : base(componente)
        {
        }
    }
}
