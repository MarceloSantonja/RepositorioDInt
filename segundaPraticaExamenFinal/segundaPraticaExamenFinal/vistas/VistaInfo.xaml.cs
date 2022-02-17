using segundaPraticaExamenFinal.vistamodelo;
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

namespace segundaPraticaExamenFinal.vistas
{
    /// <summary>
    /// Lógica de interacción para VistaInfo.xaml
    /// </summary>
    public partial class VistaInfo : Window
    {
        
        public VistaInfo()
        {
            InitializeComponent();
            this.DataContext = new VistaInfoVM();
        }

        private void CerrarButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
