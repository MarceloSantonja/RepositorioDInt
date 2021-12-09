using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeliculas
{
    class Partida
    {

        private ObservableCollection<Pelicula> peliculas;

     
        public bool PistaVista { get => pistaVista; set{ SetProperty(ref pistaVista, ) } }

        public ObservableCollection<Pelicula> Peliculas { get => peliculas; set => peliculas = value; }

        private bool pistaVista;

        public Partida(ObservableCollection<Pelicula> peliculas)
        {
            this.Peliculas = peliculas;
            
        }
    }
}
