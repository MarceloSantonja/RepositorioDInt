
using System.Windows;
using System.Windows.Controls;


namespace CaracteresLimitados
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

        private void TextoEscritoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            int tamaño = TextoEscritoTextBox.Text.Length;
            MuestraContadorTextBlock.Text = tamaño + "/140";
            if (tamaño >= 140) {
                TextoEscritoTextBox.IsReadOnly = true;
            
            }

        }




    }
}
