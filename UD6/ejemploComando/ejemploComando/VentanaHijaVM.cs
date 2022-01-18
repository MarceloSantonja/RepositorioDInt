using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploComando
{
    class VentanaHijaVM :ObservableObject
    {

        private int contador;

        private ServicioNavegacion servicio;

        public int Contador
        {
            get { return contador; }
            set {SetProperty(ref contador , value); }
        }

        public VentanaHijaVM()
        {

           
        }
    }
}
