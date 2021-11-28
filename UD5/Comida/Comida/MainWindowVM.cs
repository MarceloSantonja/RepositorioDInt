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
        private Plato platoSelecionado;

        public Plato PlatoSelecionado
        {
            get { return platoSelecionado; }
            set { 
                platoSelecionado = value;
                NotifyPropertyChanged("PlatoSelecionado");
            }
        }

       

        private ObservableCollection<String> tipos;

        public ObservableCollection<String> Tipos
        {
            get { return tipos; }
            set
            {
                tipos = value;
                NotifyPropertyChanged("Tipos");
            }
        }


        private ObservableCollection<Plato> platos;
        public ObservableCollection<Plato> Platos
        {
            get { return platos; }
            set {
                platos = value;
                NotifyPropertyChanged("Platos");
            }
        }


        public MainWindowVM()
        {
            
            Platos = Plato.GetSamples(@"E:\2DAM\DINTJavi\tema5\Imagenes");
            Tipos = new ObservableCollection<String>(){"Americana", "China","Mexicana" };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }






    }
}
