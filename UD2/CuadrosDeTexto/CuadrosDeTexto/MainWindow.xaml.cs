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

namespace CuadrosDeTexto
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

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox caja = (TextBox)sender;
            string[] datos = caja.Tag.ToString().Split('\\');
            TextBlock ayuda =  (TextBlock)FindName(datos[0]);
            if (e.Key == Key.F1)
                ayuda.Text = ayuda.Text == "" ? datos[1]:"";
        }

        private void EdadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            ErrorEdadtextBlock.Foreground = Brushes.Red;
            if (e.Key == Key.F2)
                ErrorEdadtextBlock.Text = int.TryParse(EdadTextBox.Text, out int edad) ? "" : "Edad incorrecta";

        }
    }
}
