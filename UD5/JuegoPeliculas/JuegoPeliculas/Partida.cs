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
        public const int PUNTUACION_BASE = 20;
        public int NumeroPeliculas { get; set; }

        public List<PeliculaEnJuego> PeliculasPartida { get; set; }


        private int puntuacion;
        public int Puntuacion { get => puntuacion; set => SetProperty(ref puntuacion, value); }

        private int cantidadPeliculasAdivinadas;
        public int CantidadPeliculasAdivinadas { get => cantidadPeliculasAdivinadas; set => SetProperty(ref cantidadPeliculasAdivinadas, value); }

        private PeliculaEnJuego peliculaActual;
        public PeliculaEnJuego PeliculaActual { get => peliculaActual; set => SetProperty(ref peliculaActual, value); }

        private int posicionActual;
        public int PosicionActual { get => posicionActual; set => SetProperty(ref posicionActual, value); }


        public Partida()
        {
        }

        public Partida(List<Pelicula> peliculas)
        {
            PeliculasPartida = new List<PeliculaEnJuego>();
            foreach (Pelicula pelicula in peliculas)
            {
                PeliculasPartida.Add(new PeliculaEnJuego(pelicula));

            }
            Puntuacion = 0;
            PosicionActual = 1;
            PeliculaActual = PeliculasPartida[PosicionActual - 1];
            NumeroPeliculas = PeliculasPartida.Count;
            cantidadPeliculasAdivinadas = 0;
        }

        public void AvanzaPosicion()
        {
            if (PosicionActual < NumeroPeliculas)
            {
                PosicionActual++;
                PeliculaActual = PeliculasPartida[PosicionActual - 1];
            }
        }
        public void RetrocedePosicion()
        {
            if (PosicionActual > 1)
            {
                PosicionActual--;
                PeliculaActual = PeliculasPartida[PosicionActual - 1];
            }
        }
        public void PeliculaAcertada()
        {
            int multiplicadorDificualtad = 0;

            switch (PeliculaActual.PeliculaJuego.Nivel)
            {
                case "Fácil":
                    multiplicadorDificualtad = 1;
                    break;
                case "Media": 
                    multiplicadorDificualtad = 2;
                    break;
                case "Difícil":
                    multiplicadorDificualtad = 3;
                    break;


            }

            PeliculaActual.PeliculaAdivinada = true;
            Puntuacion += PeliculaActual.PistaVista ? 
                                        (PUNTUACION_BASE * multiplicadorDificualtad) /2 :                     (PUNTUACION_BASE * multiplicadorDificualtad);
        }




    }
}
