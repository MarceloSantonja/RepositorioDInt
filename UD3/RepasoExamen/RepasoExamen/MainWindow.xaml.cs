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

namespace RepasoExamen
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

        private void NombreTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox caja = (TextBox)sender;
            if (caja.Text.Length>100)
            {
                caja.Background = Brushes.IndianRed;
            }


        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image i = sender as Image;
            if (AyudaCheckBox.IsChecked.Value)
            {
                AyudaTextBlock.Text = i.Tag.ToString();
            }
            
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            AyudaTextBlock.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox caja = new TextBox
            {
                Style = (Style)this.Resources["aficionTextBox"]
            };
            AnyadirAficionStackPanel.Children.Add(caja);
        }
    }
}
