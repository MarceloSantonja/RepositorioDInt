using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeliculas
{
    class MainWindowVM : ObservableObject
    {
        private ObservableCollection<Pelicula> peliculas;

        public ObservableCollection<Pelicula> Peliculas
        {
            get => peliculas;
            set { SetProperty(ref peliculas, value); }
        }
        private Pelicula peliculaSeleccionada;
        public Pelicula PeliculaSeleccionada
        {
            get => peliculaSeleccionada;
            set { SetProperty(ref peliculaSeleccionada, value); }
        }

        public MainWindowVM()
        {
        }
    }
}