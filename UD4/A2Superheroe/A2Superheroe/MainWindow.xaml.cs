using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace A2Superheroe
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Superheroe> heroes = Superheroe.GetSamples();
        int posicion = 0;
        public MainWindow()
        {
            InitializeComponent();
            ContenedorDockPanel.DataContext = heroes[posicion];
            CantidadheroeTextBlock.Text = heroes.Count.ToString();
          
        }

        private void AtrasImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                HeroeSelectorTextBlock.Text = (posicion+1).ToString();
                ContenedorDockPanel.DataContext = heroes[posicion];
            }


        }

        private void AdelanteImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (posicion < heroes.Count - 1)
            {
                posicion++;
                HeroeSelectorTextBlock.Text = (posicion + 1).ToString();
                ContenedorDockPanel.DataContext = heroes[posicion];
            }
        }


    }
}
