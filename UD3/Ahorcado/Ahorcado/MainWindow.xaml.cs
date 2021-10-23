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
        int fallos = 0;
        int letrasOcultas = 0;



        public MainWindow()
        {
            InitializeComponent();

            palabras.Add("telegrafo");
            palabras.Add("futbol");
            palabras.Add("caligrafia");
            palabras.Add("atardecer");
            palabras.Add("paisaje");
            String letras = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            List<Char> letrasList = letras.ToCharArray().ToList();

            int contadorLetra = 0;

            for (int fila = 0; fila < TecladoUniformGrid.Rows; fila++)
            {
                for (int columna = 0; columna < TecladoUniformGrid.Columns; columna++)
                {

                    TextBlock letra = new TextBlock
                    {
                        Text = letrasList[contadorLetra].ToString()
                    };
                    Viewbox vista = new Viewbox
                    {
                        Child = letra
                    };
                    Button boton = new Button
                    {
                        Content = vista,
                        Tag = letrasList[contadorLetra].ToString()
                    };
                    this.TecladoUniformGrid.Children.Add(boton);

                    Grid.SetRow(boton, fila);
                    Grid.SetColumn(boton, columna);
                    contadorLetra++;
                }
            }
        }
        public void GeneraPalbra()
        {
            Random r = new Random();
            int posicionAleatoria = r.Next(0, palabras.Count);
            String palabra = palabras[posicionAleatoria];
            this.PanelPalabra.Children.Clear();
            char[] letras = palabra.ToCharArray();
            foreach (char i in letras)
            {
                letrasOcultas += 1;
                TextBlock letra = new TextBlock
                {
                    Text = i.ToString().ToUpper(),
                    Style = Resources["LetrasOcultas"] as Style,
                    Tag = i,
                };
                Border bordeLetra = new Border
                {
                    Style = Resources["BordeLetra"] as Style,
                    Child = letra
                };
                this.PanelPalabra.Children.Add(bordeLetra);
            }

        }

        public void CambiaTeclas(bool isEnabled)
        {

            IList lista = TecladoUniformGrid.Children;
            for (int i = 0; i < lista.Count; i++)
            {
                Button b = lista[i] as Button;
                b.IsEnabled = isEnabled;
            }

        }
        private void NuevaPartidaButton_Click(object sender, RoutedEventArgs e)
        {

            fallos = 0;
            letrasOcultas = 0;
            GeneraPalbra();
            CambiaTeclas(true);
            RendirseButton.IsEnabled = true;
            AhoracadoImage.Source = new BitmapImage(new Uri(@".\images\" + fallos + ".jpg", UriKind.Relative));
        }

        private void RendirseButton_Click(object sender, RoutedEventArgs e)
        {
            

                fallos = 10;
                IList lista = PanelPalabra.Children;
                for (int i = 0; i < lista.Count; i++)
                {
                    Border b = lista[i] as Border;
                    b.BorderThickness = new Thickness(0);
                    (b.Child as TextBlock).Visibility = Visibility.Visible;

                }
            AhoracadoImage.Source = new BitmapImage(new Uri(@".\images\" + fallos + ".jpg", UriKind.Relative));
            MensajeFinal();

        }
        private void MensajeFinal()
        {
            CambiaTeclas(false);
            MessageBox.Show(fallos < 10 ? "GANASTE" : "PERDISTE");
            RendirseButton.IsEnabled = false;
        }
        private void Letra_Click(object sender, RoutedEventArgs e)
        {
            BuscaLetra(sender as Button);
        }
        private void BuscaLetra(Button botonPulsado)
        {

            botonPulsado.IsEnabled = false;
            string letraPosible = botonPulsado.Tag.ToString();
            bool contieneLetra = false;
            IList list = PanelPalabra.Children;
            for (int i = 0; i < list.Count; i++)
            {
                Border b = list[i] as Border;
                TextBlock textBlockLetra = b.Child as TextBlock;
                if (textBlockLetra.Text == letraPosible)
                {
                    contieneLetra = true;
                    b.BorderThickness = new Thickness(0);
                    textBlockLetra.Visibility = Visibility.Visible;
                    letrasOcultas -= 1;
                }

            }
            if (!contieneLetra)
            {
                fallos++;
                AhoracadoImage.Source= new BitmapImage(new Uri(@".\images\" + fallos + ".jpg",UriKind.Relative));
            }
            if (letrasOcultas == 0 || fallos ==10 )
            {
                MensajeFinal();
            }


        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            IList botones = TecladoUniformGrid.Children;
            for (int i = 0; i < botones.Count; i++)
            {
                Button posibleBoton = botones[i] as Button;
                if (posibleBoton.Tag.ToString() == e.Key.ToString() && posibleBoton.IsEnabled)
                {
                    BuscaLetra(posibleBoton);
                    i = botones.Count;
                }
            }
        }
    }
}
