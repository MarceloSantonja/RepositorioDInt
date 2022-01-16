using GestionPersonasU6A2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonasU6A2
{
    class DatosBaseService
    {

        public ObservableCollection<Persona> GetSamples()
        {
            ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
            personas.Add(new Persona("Pietro", 30, "Italiana"));
            personas.Add(new Persona("Julia", 25, "Española"));
            personas.Add(new Persona("Sophie", 35, "Francesa"));
            return personas;
        }
        public ObservableCollection<String> ConseguirNacionalidades()
        {
            ObservableCollection<String> nacionalidades = new ObservableCollection<String>();
            nacionalidades.Add("Italiana");
            nacionalidades.Add("Española");
            nacionalidades.Add("Francesa");
            return nacionalidades;
        }
    }
}
