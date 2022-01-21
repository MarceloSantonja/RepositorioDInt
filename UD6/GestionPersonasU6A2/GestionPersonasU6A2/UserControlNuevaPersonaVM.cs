using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
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
        private Persona nuevaPersona;

        public Persona NuevaPersona
        {
            get { return nuevaPersona; }
            set { SetProperty(ref nuevaPersona, value); }
        }


        public RelayCommand VentanaNacionalidadCommand { get; }
        public RelayCommand NuevaPersonaCommand { get; }
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
            NuevaPersonaCommand = new RelayCommand(CrearPersona);
            servicio = new ServicioNavegacion();
            WeakReferenceMessenger.Default.Register<NacionalidadCambiadaMessage>(this, (r, m) =>
            {
                Nacionalidades.Add(m.Value);
            });

        }

        private void CrearPersona()
        {
            WeakReferenceMessenger.Default.Send(new NuevaPersonaMessage(NuevaPersona));
        }

        private void AbrirVentanaNacionalidad()
        {
            servicio.AbrirVentanaNavegacion();
        }
    }
}
