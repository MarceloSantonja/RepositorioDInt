using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9
{
    class MainWindowVM : ObservableObject
    {
        private ServicioNavegacion servicio;
        
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
            servicio = new ServicioNavegacion();
            Actual = 0;
            SiguienteCommand = new RelayCommand(Avanzar);
            AbrirHijaCommand = new RelayCommand(AbrirHija);

            WeakReferenceMessenger.Default.Register<MainWindowVM, ValorActualRequestMessage>(this, (r, m) =>
            {
                m.Reply(r.Actual);
            });

        }

        private void AbrirHija()
        {
            servicio.AbrirVentanaHija();
        }

        private void Avanzar()
        {
            Actual++;
            WeakReferenceMessenger.Default.Send(new ValorCambiadoMessage(Actual));

        }
    }
}
