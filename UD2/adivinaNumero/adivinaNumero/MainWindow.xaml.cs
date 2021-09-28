using System;

using System.Windows;


namespace AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numeroAleatorio;
        public MainWindow()
        {
            InitializeComponent();
            CreaNumeroAleatorio();
        }
        public void CreaNumeroAleatorio()
        {
            Random semilla = new Random();
            numeroAleatorio = semilla.Next(0, 101);
        }



        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(CajaNumerosTextBox.Text, out int numero))
            {
                if (numeroAleatorio == numero)
                {
                    RespuestaTextBlock.Text = "Has acertado";
                }
                else if (numeroAleatorio < numero)
                {
                    RespuestaTextBlock.Text = "Te has pasado";
                }
                else
                {
                    RespuestaTextBlock.Text = "Te has quedado corto";

                }
            }
            else
                RespuestaTextBlock.Text = "Eso no es un número";


        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            CreaNumeroAleatorio();
            RespuestaTextBlock.Text = "";
        }
    }


}
