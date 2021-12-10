using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;


namespace JuegoPeliculas
{
    class Partida : ObservableObject
    {

        private List<PeliculaEnJuego> peliculasPartida;

        public List<PeliculaEnJuego> PeliculasPartida { get => peliculasPartida; set => peliculasPartida = value; }


        private int puntuacion;
        public int Puntuacion { get => puntuacion; set { SetProperty(ref puntuacion, value); } }

        private PeliculaEnJuego peliculaActual;
        public PeliculaEnJuego PeliculaActual { get => peliculaActual; set { SetProperty(ref peliculaActual, value); } }

        private int posicionActual;
        public int PosicionActual { get => posicionActual; set { SetProperty(ref posicionActual, value); } }

      
        
        public Partida(List<Pelicula> peliculas)
        {
            PeliculasPartida = new List<PeliculaEnJuego>();
            foreach (Pelicula pelicula in peliculas)
            {
                PeliculasPartida.Add(new PeliculaEnJuego( pelicula));

            }
            Puntuacion = 0;
            PosicionActual = 1;
            peliculaActual = PeliculasPartida[PosicionActual-1];
        }

        public void AvanzaPosicion()
        {
            if (PosicionActual < PeliculasPartida.Count())
            {
                PosicionActual++;
                peliculaActual = peliculasPartida[PosicionActual-1];
            }
        }
        public void RetrocedePosicion()
        {
            if (PosicionActual > 1){
                PosicionActual--;
                peliculaActual = peliculasPartida[PosicionActual - 1];
            }
        }




    }
}
