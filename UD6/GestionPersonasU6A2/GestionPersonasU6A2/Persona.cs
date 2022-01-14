using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonasU6A2
{
    class Persona :ObservableObject
    {

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre , value); }
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
            set {SetProperty(ref edad, value); }
        }

        public Persona(string nombre, string nacionalidad, int edad)
        {
            Nombre = nombre;
            Nacionalidad = nacionalidad;
            Edad = edad;
        }


    }
}
