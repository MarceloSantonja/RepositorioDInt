using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp10
{
    class MainWindowVM : ObservableObject
    {
        private ServicioNavegacion servicio;

        private UserControl opcion;

        public UserControl Opcion
        {
            get { return opcion; }
            set { SetProperty(ref opcion,value); }
        }


        public RelayCommand AbrirVentanaCommand { get; }
        
        public RelayCommand AbrirUC1Command { get; }
        public RelayCommand AbrirUC2Command { get; }
        public MainWindowVM()
        {
            AbrirVentanaCommand = new RelayCommand(AbrirVentana);
            AbrirUC1Command = new RelayCommand(AbrirUC1);
            AbrirUC2Command = new RelayCommand(AbrirUC2);
            servicio = new ServicioNavegacion();
            Opcion = servicio.AbrirUC1();

        }

        private void AbrirUC2()
        {
            Opcion = servicio.AbrirUC2();
        }

        private void AbrirUC1()
        {
            Opcion = servicio.AbrirUC1();
        }

        private void AbrirVentana()
        {
            servicio.AbrirVentanaHija();
        }

      
    }
}
