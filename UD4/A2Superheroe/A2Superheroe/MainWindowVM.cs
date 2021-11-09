using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Superheroe
{
    class MainWindowVM :INotifyPropertyChanged
    {
        private List<Superheroe> lista;

        

        public MainWindowVM()
        {
            lista = Superheroe.GetSamples();
            SuperheroeActual = lista[0];
            PosicionActual = 1;
            TotalHeroes = lista.Count;
        }

        // Conectar vista a vistaMoledo
    

        private Superheroe superheroeActual;

        public Superheroe SuperheroeActual
        {
            get { return superheroeActual; }
            set { 
                superheroeActual = value;
                NotifyPropertyChanged("SuperheroeActual");
            }
        }
        private int posicionActual;

        public int PosicionActual
        {
            get { return posicionActual; }
            set { 
                posicionActual = value;
                NotifyPropertyChanged("PosicionActual");
            }
        }


        private int totalHeroes;

        public int TotalHeroes
        {
            get { return totalHeroes; }
            set { 
                totalHeroes = value;
                NotifyPropertyChanged("TotalHeroes");
            }
        }



        

        public void Avanzar() {

            if (PosicionActual < TotalHeroes)
            {
                PosicionActual++;
                SuperheroeActual = lista[PosicionActual - 1];
            }

        }

        public void Retroceder() {
            if (PosicionActual > 1)
            {
                PosicionActual--;
                SuperheroeActual = lista[PosicionActual - 1];
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
