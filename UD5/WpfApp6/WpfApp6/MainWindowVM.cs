using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<string> provincias = new ObservableCollection<string>();

        public MainWindowVM()
        {
            Provincias.Add("Alicante");
            Provincias.Add("Valencia");
            Provincias.Add("Castellón");

            ListaPersonas.Add(new Persona("Pedro", 35));
            ListaPersonas.Add(new Persona("Marta", 30));

        }

        public ObservableCollection<string> Provincias
        {
            get { return provincias; }
            set { 
                provincias = value;
                NotifyPropertyChanged("Provincias");
            }
        }

        private ObservableCollection<Persona> listaPersonas = new ObservableCollection<Persona>();

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { 
                listaPersonas = value;
                NotifyPropertyChanged("ListaPersonas");
            }
        }

        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { 
                personaSeleccionada = value;
                NotifyPropertyChanged("PersonaSeleccionada");
            }
        }



        public void AñadirProvincia()
        {
            Provincias.Add("Murcia");
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
