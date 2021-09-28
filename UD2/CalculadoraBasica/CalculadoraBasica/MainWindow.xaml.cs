
using System.Windows;
using System.Windows.Controls;


namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int operando1;
        private int operando2;
 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            bool numerosCorrectos = int.TryParse(Operando1TextBox.Text, out operando1) && int.TryParse(Operando2TextBox.Text, out operando2);
            if (numerosCorrectos)
            {
                switch (OperadorTextBox.Text)
                {
                    case "*":
                        ResultadoTextBox.Text = (operando1 * operando2).ToString();
                        break;
                    case "+":
                        ResultadoTextBox.Text = (operando1 + operando2).ToString();
                        break;
                    case "-":
                        ResultadoTextBox.Text = (operando1 - operando2).ToString();
                        break;
                    case "/":
                        ResultadoTextBox.Text = (operando1 / operando2).ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Se ha producido un error.Revise los operandos");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OperadorTextBox.Text == "*" || OperadorTextBox.Text == "+" || OperadorTextBox.Text == "-" || OperadorTextBox.Text == "/") { CalcularButton.IsEnabled = true; }
            else
            {
                CalcularButton.IsEnabled = false;
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Clear();
            Operando2TextBox.Clear();
            OperadorTextBox.Clear();
            ResultadoTextBox.Clear();
        }
    }
}
