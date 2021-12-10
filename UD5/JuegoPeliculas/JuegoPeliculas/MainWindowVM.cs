using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JuegoPeliculas
{
    class MainWindowVM : ObservableObject
    {
        private const int TAMAÑO_PARTIDA = 5;
        private readonly ServicioDialogos sDialogo;
        private readonly ServicioJson sJson;


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
        private ObservableCollection<string> nivel;
        public ObservableCollection<string> Nivel
        {
            get => nivel;
            set { SetProperty(ref nivel, value); }
        }
        private ObservableCollection<string> generos;
        public ObservableCollection<string> Generos
        {
            get => generos;
            set { SetProperty(ref generos, value); }
        }
        private Partida partidaActual;
        internal Partida PartidaActual
        {
            get => partidaActual;
            set{SetProperty(ref partidaActual, value);}
        }

        public MainWindowVM()
        {
            Peliculas = new ObservableCollection<Pelicula>();
            sDialogo = new ServicioDialogos();
            sJson = new ServicioJson();
            Nivel = new ObservableCollection<string> { "Fácil", "Media", "Difícil" };
            Generos = new ObservableCollection<string> { "Acción", "Ciencia-Ficción", "Comedia", "Drama", "Terror" };



        }

        public void CargarJson()
        {
            string ruta = sDialogo.ObtenerRutaArchivoLocal(ServicioDialogos.tipoArchivo.JSON);
            if (ruta != "")
            {
                Peliculas = sJson.CargarJSON(ruta);
                sDialogo.MostrarMensaje("Se han cardado " + Peliculas.Count() + " Peliculas", "Cargar JSON", MessageBoxImage.Information);
            }

        }
        public void GuardarJson()
        {
            string ruta = sDialogo.ObtenerRutaArchivoGuardar(ServicioDialogos.tipoArchivo.JSON);
            if (ruta != "")
            {
                sJson.GuardarJSON(Peliculas, ruta);
                sDialogo.MostrarMensaje("Se han guardado las peliculasPartida", "Guardar JSON", MessageBoxImage.Information);
            }
        }

        public void GeneraPartida()
        {
            int posicionPelicula;
            List<Pelicula> peliculasPartida = new List<Pelicula>();
            List<Pelicula> peliculasAuxiliar = new List<Pelicula>(Peliculas);
            Random random = new Random();


            if (peliculasAuxiliar.Count() < TAMAÑO_PARTIDA)
            {
                sDialogo.MostrarMensaje("No se ha podido crear la partidaActual, no hay suficientes peliculasPartida", "Nueva partidaActual", MessageBoxImage.Error);
            }
            else
            {
                for (int i = 0; i < TAMAÑO_PARTIDA; i++)
                {
                    posicionPelicula = random.Next(peliculasAuxiliar.Count());

                    peliculasPartida.Add(peliculasAuxiliar[posicionPelicula]);
                    peliculasAuxiliar.Remove(peliculasAuxiliar[posicionPelicula]);
                }


                PartidaActual = new Partida(peliculasPartida);
                sDialogo.MostrarMensaje("Se ha creado la partidaActual", "Nueva partidaActual", MessageBoxImage.Information);
            }




        }


    }
}