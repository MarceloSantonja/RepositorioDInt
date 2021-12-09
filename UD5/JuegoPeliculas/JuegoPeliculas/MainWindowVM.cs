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
        private ServicioDialogos sDialogo;
        private ServicioJson sJson;

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
            sDialogo = new ServicioDialogos();
            sJson = new ServicioJson();
        }

        public void CargarJson()
        {
            string ruta =sDialogo.ObtenerRutaArchivoLocal(ServicioDialogos.tipoArchivo.JSON);
            if (ruta!="")
            {
                Peliculas= sJson.CargarJSON(ruta);
            }
        }
        public void GuardarJson()
        {
            string ruta = sDialogo.ObtenerRutaArchivoGuardar(ServicioDialogos.tipoArchivo.JSON);
            if (ruta != "")
            {
                sJson.GuardarJSON(Peliculas,ruta);
            }
        }



    }
}