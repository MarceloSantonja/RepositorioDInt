using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GestionPersonasU6A2
{
    class MainWindowVM :ObservableObject
    {
        private ServicioNavegacion servicio;

        private UserControl opcion;

        public UserControl Opcion
        {
            get { return opcion; }
            set { SetProperty(ref opcion , value); }
        }

        public RelayCommand AbrirListadoCommand { get; }

        public RelayCommand AbrirNuevaPersonaCommand { get; }

        public MainWindowVM()
        {
            AbrirListadoCommand = new RelayCommand(AbrirListado);
            AbrirNuevaPersonaCommand = new RelayCommand(AbrirNuevaPersona);
            servicio = new ServicioNavegacion();
            Opcion = servicio.AbrirListado();
        }

        private void AbrirListado()
        {
            Opcion = servicio.AbrirListado();
        }

        private void AbrirNuevaPersona()
        {
            Opcion = servicio.AbrirNuevaPersona();
        }
    }
}
