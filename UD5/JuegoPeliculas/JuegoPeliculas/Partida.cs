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

        private List<Pelicula> peliculas;

        public List<Pelicula> Peliculas { get => peliculas; set => peliculas = value; }

        private List<bool> pistaVista;
        public List<bool> PistaVista { get => pistaVista; set=> pistaVista= value;  }

        private int puntuacion;
        public int Puntuacion { get => puntuacion; set => puntuacion = value; }

        private Pelicula peliculaActual;
        public Pelicula PeliculaActual { get => peliculaActual; set => peliculaActual = value; }

       
        



        public Partida(List<Pelicula> peliculas)
        {
            Peliculas = peliculas;
            PistaVista = new List<bool>(peliculas.Count());
            for (int i = 0; i < peliculas.Count(); i++)
            {
                PistaVista[i] = false;
            }
            Puntuacion = 0;



        }






    }
}
