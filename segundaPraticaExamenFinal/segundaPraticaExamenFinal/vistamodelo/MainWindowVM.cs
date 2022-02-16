using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using segundaPraticaExamenFinal.modelo;
using segundaPraticaExamenFinal.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace segundaPraticaExamenFinal.vistamodelo
{
    class MainWindowVM: ObservableObject
    {
        public ServicioNavegacion Navegacion { get;}
        public UserControl UCCargado { get; }
        public RelayCommand InfoCommand { get; }

        private Componente componenteSeleccionado;

        public Componente ComponenteSeleccionado
        {
            get { return componenteSeleccionado; }
            set { SetProperty(ref componenteSeleccionado, value); }
        }

        private ObservableCollection<Componente> componentes;

        public ObservableCollection<Componente> Componentes
        {
            get { return componentes; }
            set { SetProperty(ref componentes, value); }
        }

        public MainWindowVM()
        {
            Componentes = Componente.GetSamples();
            Navegacion = new ServicioNavegacion();
            InfoCommand = new RelayCommand(AbrirInfo);
        }

        private void AbrirInfo()
        {
            Navegacion.AbrirVentanaInfo();
        }
    }
}
