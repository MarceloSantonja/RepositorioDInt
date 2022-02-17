using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using segundaPraticaExamenFinal.modelo;
using segundaPraticaExamenFinal.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace segundaPraticaExamenFinal.vistamodelo
{
    class MainWindowVM: ObservableObject
    {
        public ServicioNavegacion Navegacion { get;}

        private UserControl contenidoVista;
        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }
        public RelayCommand InfoCommand { get; }
        public RelayCommand ConsultarCommand { get; }
        
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
            
            WeakReferenceMessenger.Default.Register<MainWindowVM, ComponenteRequestMessage>(this, (r, m) => { m.Reply(r.ComponenteSeleccionado); });
            ConsultarCommand = new RelayCommand(Consultar);
        }

        private void AbrirInfo()
        {
            Navegacion.AbrirVentanaInfo();
        }

        private void Consultar()
        {
            ContenidoVista = Navegacion.AbrirInfoUserControl();
        }
    }
}
