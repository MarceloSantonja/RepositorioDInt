using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {




        private ObservableCollection<string> tipos;

        public ObservableCollection<string> Tipos
        {
            get => tipos;
            set
            {
                tipos = value;
                NotifyPropertyChanged("Tipos");
            }
        }


        private ObservableCollection<Plato> platos;
        public ObservableCollection<Plato> Platos
        {
            get => platos;
            set
            {
                platos = value;
                NotifyPropertyChanged("Platos");
            }
        }

        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get => platoSeleccionado;
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        public MainWindowVM()
        {
            Platos = Plato.GetSamples(@"E:\2DAM\DINTJavi\tema5\Imagenes");
            Tipos = new ObservableCollection<string> { "Americana", "China", "Mexicana" };
        }

        public void LimpiarSeleccion()
        {
            PlatoSeleccionado = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
