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
using System.Windows.Shapes;

namespace GestionPersonasU6A2
{
    /// <summary>
    /// Lógica de interacción para AddNacionalidadWindow.xaml
    /// </summary>
    public partial class AddNacionalidadWindow : Window
    {
        private AddNacionalidadWindowVM vm;
        public AddNacionalidadWindow()
        {
            InitializeComponent();
            vm = new AddNacionalidadWindowVM();
            this.DataContext = vm;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.Aceptar();

            DialogResult = true;

        }
    }
}
