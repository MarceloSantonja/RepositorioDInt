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

namespace examen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AñadirButton_Click(object sender, RoutedEventArgs e)
        {
            Image estrella = new Image
            {
                Source = new BitmapImage(new Uri(@".\images\star.png", UriKind.Relative)),
                Height = 100

            };
            EstrellasWrapPanel.Children.Add(estrella);
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock texto = (TextBlock)sender;
            texto.FontWeight = FontWeights.Bold;
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock texto = (TextBlock)sender;
            texto.FontWeight = FontWeights.Normal;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox caja = (TextBox)sender;
            if (e.Key.ToString()== "F1")
            {
                caja.Text = caja.Tag.ToString();
            }
            
        }
    }
}
