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
        private int platoSelecionado;

        public int PlatoSelecionado
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
            
            Platos = Plato.GetSamples(@"D:\2DAM\DINTJavi\tema5\Imagenes");
           
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }






    }
}
