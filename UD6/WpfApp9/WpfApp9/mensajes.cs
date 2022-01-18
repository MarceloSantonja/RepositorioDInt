using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9
{
    public class ValorActualRequestMessage: RequestMessage<int>{}

    public class ValorCambiadoMessage : ValueChangedMessage<int> {

        public ValorCambiadoMessage(int valor) : base(valor) { }
    }
}
