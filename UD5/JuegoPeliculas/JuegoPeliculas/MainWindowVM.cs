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
        private const int TAMAÑO_PARTIDA = 5;
        private readonly ServicioDialogos sDialogo;
        private readonly ServicioJson sJson;
        private Partida partida;

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
        public ObservableCollection<string> Nivel { 
            get => nivel; 
            set { SetProperty(ref nivel, value);} 
        }
        private ObservableCollection<string> generos;
        public ObservableCollection<string> Generos
        {
            get => generos;
            set { SetProperty(ref generos, value); }
        }




        public MainWindowVM()
        {
            Peliculas = new ObservableCollection<Pelicula>();
            sDialogo = new ServicioDialogos();
            sJson = new ServicioJson();
            Nivel = new ObservableCollection<string> { "Fácil","Media","Difícil"};
            Generos = new ObservableCollection<string> { "Acción", "Ciencia-Ficción", "Comedia", "Drama", "Terror" };
            

            
        }

        public void CargarJson()
        {
            string ruta = sDialogo.ObtenerRutaArchivoLocal(ServicioDialogos.tipoArchivo.JSON);
            if (ruta != "")
            {
                Peliculas = sJson.CargarJSON(ruta);
                sDialogo.MostrarMensaje("Se han cardado " + Peliculas.Count() + " Peliculas");
            }

        }
        public void GuardarJson()
        {
            string ruta = sDialogo.ObtenerRutaArchivoGuardar(ServicioDialogos.tipoArchivo.JSON);
            if (ruta != "")
            {
                sJson.GuardarJSON(Peliculas, ruta);
                sDialogo.MostrarMensaje("Se han guardado las peliculas");
            }
        }

        public void GeneraPartida() { 
        
            if(TAMAÑO_PARTIDA == Peliculas.Count())
            {

                partida = new Partida(new List<Pelicula>(Peliculas));

            }
        
        
        }


    }
}