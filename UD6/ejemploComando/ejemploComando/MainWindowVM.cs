using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploComando
{
    class MainWindowVM : ObservableObject
    {

        private int actual;

        public int Actual
        {
            get { return actual; }
            set { SetProperty(ref actual, value); }
        }


        public RelayCommand SiguienteCommand { get; }
        public RelayCommand AbrirHijaCommand { get; }

        public MainWindowVM()
        {
            Actual = 0;

            SiguienteCommand = new RelayCommand(Avanzar);
            AbrirHijaCommand = new RelayCommand(AbrirHija());
            servicio = new ServicioNavegacion();
        }

        private Action AbrirHija()
        {
            throw new NotImplementedException();
        }

        private void Avanzar()
        {
            Actual++;
        }
    }
}
