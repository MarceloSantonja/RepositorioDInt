using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeliculas
{
    class PeliculaEnJuego : ObservableObject
    {
        private Pelicula peliculaJuego;
        public Pelicula PeliculaJuego { get => peliculaJuego; set { SetProperty(ref peliculaJuego, value); } }
        private bool peliculaVista;
        public bool PeliculaVista { get => peliculaVista; set {SetProperty(ref peliculaVista, value); } }

        public PeliculaEnJuego(Pelicula pelicula)
        {
            PeliculaJuego = pelicula;
            peliculaVista = false;
        }

    }
}
