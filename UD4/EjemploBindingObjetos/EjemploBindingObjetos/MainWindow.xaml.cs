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

namespace EjemploBindingObjetos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona paco = new Persona("Paco",35);
        public MainWindow()
        {
            InitializeComponent();
            PanelStackPanel.DataContext = paco;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("paco" + paco.Edad);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            paco.Edad++;
        }
    }
}
