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

namespace TextoConFormato
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

        private void EscribeTextBox_TextChanged(object sender, TextChangedEventArgs e) => SalidaTextBlock.Text = EscribeTextBox.Text;

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e) => SalidaTextBlock.FontWeight = FontWeights.Bold;

        private void CheckBox_Checked(object sender, RoutedEventArgs e) => SalidaTextBlock.FontStyle = FontStyles.Italic;

        private void Azul_Checked(object sender, RoutedEventArgs e) => SalidaTextBlock.Foreground = Brushes.Blue;

        private void Rojo_Checked(object sender, RoutedEventArgs e) => SalidaTextBlock.Foreground = Brushes.Red;

        private void Verde_Checked(object sender, RoutedEventArgs e) => SalidaTextBlock.Foreground = Brushes.Green;


        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e) => SalidaTextBlock.FontWeight = FontWeights.Normal;

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e) => SalidaTextBlock.FontStyle = FontStyles.Normal;

    }
}
