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
        private readonly ServicioAzureBlobStorage sAzure;

        private ObservableCollection<Pelicula> peliculas;
        private Pelicula peliculaSeleccionada;
        private Pelicula peliculaFormulario;
        private ObservableCollection<string> nivel;
        private ObservableCollection<string> generos;
        private Partida partidaActual;
        private bool estaEditando;
        private bool estaCreandoPelicula;
        private bool existePartida;

        public ObservableCollection<Pelicula> Peliculas
        {
            get => peliculas;
            set => SetProperty(ref peliculas, value);
        }
        public Pelicula PeliculaSeleccionada
        {
            get => peliculaSeleccionada;
            set => SetProperty(ref peliculaSeleccionada, value);
        }
        public Pelicula PeliculaFormulario
        {
            get => peliculaFormulario;
            set => SetProperty(ref peliculaFormulario, value);
        }
        public ObservableCollection<string> Nivel
        {
            get => nivel;
            set => SetProperty(ref nivel, value);
        }
        public ObservableCollection<string> Generos
        {
            get => generos;
            set => SetProperty(ref generos, value);
        }
        public Partida PartidaActual
        {
            get => partidaActual;
            set => SetProperty(ref partidaActual, value);
        }
        public bool EstaEditando
        {
            get => estaEditando;
            set { SetProperty(ref estaEditando, value); }
        }
        public bool EstaCreandoPelicula
        {
            get => estaCreandoPelicula;
            set { SetProperty(ref estaCreandoPelicula, value); }
        }
        public bool ExistePartida
        {
            get => existePartida;
            set { SetProperty(ref existePartida, value); }
        }

       

        public MainWindowVM()
        {
            Peliculas = new ObservableCollection<Pelicula>();
            sDialogo = new ServicioDialogos();
            sJson = new ServicioJson();
            sAzure = new ServicioAzureBlobStorage();
            Nivel = new ObservableCollection<string> { "Fácil", "Media", "Difícil" };
            Generos = new ObservableCollection<string> { "Acción", "Ciencia-Ficción", "Comedia", "Drama", "Terror" };
            EstaEditando = false;
            ExistePartida = false;
            EstaCreandoPelicula = false;
          
        }

        public void CargarJson()
        {
            string ruta = sDialogo.ObtenerRutaArchivoLocal(ServicioDialogos.tipoArchivo.JSON);
            if (ruta != "")
            {
                Peliculas = sJson.CargarJSON(ruta);
                sDialogo.MostrarMensaje("Se han cardado " + Peliculas.Count() + " peliculas", "Cargar JSON", MessageBoxImage.Information);
            }
        }
        public void CargarImagen()
        {
            string ruta = sDialogo.ObtenerRutaArchivoLocal(ServicioDialogos.tipoArchivo.Imagen);
            if (ruta != "")
                PeliculaSeleccionada.Cartel = sAzure.AlmacenarImagenEnNube( ruta);
        }
        public void GuardarJson()
        {
            string ruta = sDialogo.ObtenerRutaArchivoGuardar(ServicioDialogos.tipoArchivo.JSON);
            if (ruta != "")
            {
                sJson.GuardarJSON(Peliculas, ruta);
                sDialogo.MostrarMensaje("Se han guardado las peliculas", "Guardar JSON", MessageBoxImage.Information);
            }
        }
        public void EditarPelicula()
        {
            
            if (PeliculaSeleccionada == null)
            {
                sDialogo.MostrarMensaje("No hay ninguna pelicula Seleccionada", "Error", MessageBoxImage.Error);
            }
            else
            {
                EstaEditando = true;
                PeliculaFormulario = new Pelicula(PeliculaSeleccionada);
            }
            
        }

        public void CrearPelicula()
        {
            EstaEditando = true;
            EstaCreandoPelicula = true;// este booleano lo cree despues de intentar varias veces hacerlo solo con el otro pero no lo meti en el xaml, porque no lo veia necesario y porque sirve para la doble funcion que tienen los metodos de Confirmar datos y cancelar datos, se que hay acoplamiento en esos botones porque se usan para aceptar la edicion y creación pero le di muchas vueltas y esto fue lo que se me ocurrio
            PeliculaSeleccionada = new Pelicula();
        }
        public void EliminarPelicula()
        {
            if (PeliculaSeleccionada == null)
            {
                sDialogo.MostrarMensaje("No hay ninguna pelicula Seleccionada", "Error", MessageBoxImage.Error);
            }
            else
            {
                Peliculas.Remove(PeliculaSeleccionada);
            }
        }
        public void ConfirmarDatos()
        {
            if (PeliculaSeleccionada.Cartel == "" ||
                PeliculaSeleccionada.Titulo == "" ||
                PeliculaSeleccionada.Pista == "")
            {
                sDialogo.MostrarMensaje(String.Format("Falta:\n {0}{1}{2}",
                                         PeliculaSeleccionada.Cartel == "" ? "-El cartel\n" : "",
                                         PeliculaSeleccionada.Titulo == "" ? "-El titulo\n" : "",
                                         PeliculaSeleccionada.Pista == "" ? "-La pista\n" : ""
                                         )
                                        , "Faltan datos"
                                        , MessageBoxImage.Error);
            }
            else
            {
                EstaEditando = false;
                if (EstaCreandoPelicula)
                {
                    EstaCreandoPelicula = false;
                    Peliculas.Add(PeliculaSeleccionada);
                }
                else
                {
                    PeliculaFormulario = null;
                }
                
                
                sDialogo.MostrarMensaje("Datos guardados con exito!!!", "Operación realizada", MessageBoxImage.Exclamation);
            }
        }
        public void CancelarDatos()
        {
            EstaEditando = false;
            if (EstaCreandoPelicula)
            {
                EstaCreandoPelicula = false;
            }
            else
            {
                Peliculas.Remove(PeliculaSeleccionada);
                Peliculas.Add(PeliculaFormulario);
                peliculaFormulario = null;
            }

            sDialogo.MostrarMensaje("No se ha realizado cambios", "Operación cancelada", MessageBoxImage.Exclamation);

        }

        public void GeneraPartida()
        {
            int posicionPelicula;
            List<Pelicula> peliculasPartida = new List<Pelicula>();
            List<Pelicula> peliculasAuxiliar = new List<Pelicula>(Peliculas);
            Random random = new Random();


            if (peliculasAuxiliar.Count < TAMAÑO_PARTIDA)
            {
                sDialogo.MostrarMensaje("No se ha podido crear la partida, no hay suficientes peliculas!!", "Nueva partida", MessageBoxImage.Error);
            }
            else
            {
                ExistePartida = true;
                for (int i = 0; i < TAMAÑO_PARTIDA; i++)
                {
                    posicionPelicula = random.Next(peliculasAuxiliar.Count);
                    peliculasPartida.Add(peliculasAuxiliar[posicionPelicula]);
                    peliculasAuxiliar.Remove(peliculasAuxiliar[posicionPelicula]);
                }
                PartidaActual = new Partida(peliculasPartida);
                sDialogo.MostrarMensaje("Se ha creado la partida", "Nueva partida", MessageBoxImage.Information);
            }
        }
        public void FinalizarPartida()
        {
            ExistePartida = false;
            sDialogo.MostrarMensaje("La puntuación alcanzada ha sido: " + PartidaActual.Puntuacion, "Parida Finalizada", MessageBoxImage.Asterisk);
            PartidaActual = null;
        }

        public void ComprobarRespuesta()
        {
            sDialogo.MostrarMensaje(PartidaActual.PeliculaActual.VariableQueMeHeCreadoParaHacerBindingALaRespuestaDeUsuarioPorQueNoSePuedenPasarDatosDeLaVista, "Respuesta correcta", MessageBoxImage.Information);
            
            if (PartidaActual.PeliculaActual.VariableQueMeHeCreadoParaHacerBindingALaRespuestaDeUsuarioPorQueNoSePuedenPasarDatosDeLaVista ==
                PartidaActual.PeliculaActual.PeliculaJuego.Titulo)
            {
                sDialogo.MostrarMensaje("Pelicula acertada", "Respuesta correcta", MessageBoxImage.Information);
                PartidaActual.PeliculaAcertada();
            }
            else
            {
                sDialogo.MostrarMensaje("Ese no es el titulo de la pelicula", "Respuesta incorrecta", MessageBoxImage.Hand);
            }
        }




    }
}