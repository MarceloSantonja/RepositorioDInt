using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using ultimaPracticaExamen.modelo;
using ultimaPracticaExamen.servicio;

namespace ultimaPracticaExamen.VistaModelo
{
    class MainWindowVM : ObservableObject
    {
        private ServicioNavegacion sNavegacion;

        private ObservableCollection<Componente> componentes;

        public ObservableCollection<Componente> Componentes
        {
            get { return componentes; }
            set { SetProperty(ref componentes, value); }
        }


        private Componente componenteSeleccionado;

        public Componente ComponenteSeleccionado
        {
            get { return componenteSeleccionado; }
            set { SetProperty(ref componenteSeleccionado, value); }
        }
        private UserControl contenidoVista;

        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }

        private RelayCommand infoCommand;

        public RelayCommand InfoCommand
        {
            get { return infoCommand; }
            set { SetProperty(ref infoCommand, value); }
        }
        private RelayCommand abreUserControlCommand;

        public RelayCommand AbreUserControlCommand
        {
            get { return abreUserControlCommand; }
            set { SetProperty(ref abreUserControlCommand, value); }
        }

        public MainWindowVM()
        {
            componentes = Componente.GetSamples();
            sNavegacion = new ServicioNavegacion();
            InfoCommand = new RelayCommand(AbrirInfo);
            abreUserControlCommand = new RelayCommand(AbrirUserControl);
            WeakReferenceMessenger.Default.Register<MainWindowVM, ComponenteRequestMessage>(this, (r, m) =>
            {
                m.Reply(r.ComponenteSeleccionado);
            });

        }

        private void AbrirUserControl()
        {

            ContenidoVista = sNavegacion.AbrirUserControl();
        }

        private void AbrirInfo()
        {
            sNavegacion.AbrirVentataInfo();
        }


    }
}
