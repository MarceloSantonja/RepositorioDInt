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
            
            Platos = Plato.GetSamples(@"D:\2DAM\DINT javi\tema5\Imagenes");
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }






    }
}
