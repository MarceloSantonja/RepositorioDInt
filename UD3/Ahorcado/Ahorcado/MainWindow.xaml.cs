using System;
using System.Collections;
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

namespace Ahorcado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> palabras = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            
            palabras.Add("telegrafo");
            palabras.Add("futbol");
            palabras.Add("caligrafia");
            palabras.Add("atardecer");
            palabras.Add("paisaje");








        }

        private void NuevaPartidaButton_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int posicionAleatoria =r.Next(0, palabras.Count + 1);

            String palabra = palabras[posicionAleatoria];

            char[] letras = palabra.ToCharArray();


            TextBlock letra = new TextBlock
            {
                FontSize = 32,
                

            };

        }
    }
}
