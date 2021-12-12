using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JuegoPeliculas
{

    public partial class MainWindow : Window
    {
        readonly MainWindowVM vm = new MainWindowVM();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
          
        }

        private void CargarJsonBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.CargarJson();

        }

        private void GuardarJsonBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.GuardarJson();
        }

        private void NuevaPartidaBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.GeneraPartida();
        }

        private void RetrocederBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.PartidaActual.RetrocedePosicion();
        }

        private void AvanzarBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.PartidaActual.AvanzaPosicion();
        }

        private void AnyadirPeliculaBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.CrearPelicula();
        }

        private void EditarPeliculaBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.EditarPelicula();
        }

        private void EliminarPeliculaBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.EliminarPelicula();
        }

        private void ConfirmarBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.ConfirmarDatos();
        }

        private void CancelarBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.CancelarDatos();
        }

        private void ExaminarBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.CargarImagen();
        }

        private void FinalizarPartidaBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.FinalizarPartida();
        }

        private void ValidarBoton_Click(object sender, RoutedEventArgs e)
        {
            vm.ComprobarRespuesta();
        }
    }
}
