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

namespace superhéroes
{
    
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<SuperHeroe> heroes = SuperHeroe.GetSamples();
        int posicion = 0;
        // para los botones con flechas hay que poner 
        public MainWindow()
        {
            InitializeComponent();
            ContenedorStackPanel.DataContext = heroes[posicion];
            CantidadheroeTextBlock.Text = heroes.Count.ToString();


        }

        public class VillanoConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return ((bool)value) ? Brushes.PaleGreen : Brushes.IndianRed;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }

        private void AtrasImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (posicion >0 )
            {
                posicion--;
                HeroeSelectorTextBlock.Text = posicion.ToString();
                ContenedorStackPanel.DataContext = heroes[posicion];
            }
          
            
        }

        private void AdelanteImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (posicion < heroes.Count -1)
            {
                posicion++;
                HeroeSelectorTextBlock.Text = posicion.ToString();
                ContenedorStackPanel.DataContext = heroes[posicion];
            }
        }



    }
}
