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
        private bool pistaVista;
        public bool PistaVista { get => pistaVista; set {SetProperty(ref pistaVista, value); } }

        private bool peliculaAdivinada;
        public bool PeliculaAdivinada { get => peliculaAdivinada; set { SetProperty(ref peliculaAdivinada, value); } }
        private string respuestaPelicula;
        public string RespuestaPelicula { get => respuestaPelicula; set { SetProperty(ref respuestaPelicula, value); } }




        public PeliculaEnJuego(Pelicula pelicula)
        {
            PeliculaJuego = pelicula;
            PistaVista = false;
            PeliculaAdivinada = false;
        }

   

    }
}
