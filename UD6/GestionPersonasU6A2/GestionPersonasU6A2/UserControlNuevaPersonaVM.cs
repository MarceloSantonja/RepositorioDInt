using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonasU6A2
{
    class UserControlNuevaPersonaVM : ObservableObject
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private String nacionalidad;

        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }
        public RelayCommand VentanaNacionalidadCommand { get; }

        private ObservableCollection<String> nacionalidades;

        public ObservableCollection<String> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }
        private DatosBaseService ServicioPersonas { get; }

        private ServicioNavegacion servicio;

        public UserControlNuevaPersonaVM()
        {
            ServicioPersonas = new DatosBaseService();
            Nacionalidades = ServicioPersonas.ConseguirNacionalidades();
            VentanaNacionalidadCommand = new RelayCommand(AbrirVentanaNacionalidad);
            servicio = new ServicioNavegacion();
        }

        private void AbrirVentanaNacionalidad()
        {
            servicio.AbrirVentanaNavegacion();
        }
    }
}
