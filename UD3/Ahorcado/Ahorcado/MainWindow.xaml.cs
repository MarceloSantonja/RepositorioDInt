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
            String letras = "ABCDEFGHIJKLMNÑOPQRSTUVWYZ";
            List<Char> letrasList = letras.ToCharArray().ToList();

            int contadorLetra = 0;
            for (int fila = 0; fila < 3; fila++)
            {

                for (int columna = 0; columna < 7; columna++)
                {

                    TextBlock letra = new TextBlock
                    {
                        Text = letrasList[contadorLetra++].ToString()
                    };
                    Viewbox vista = new Viewbox
                    {

                        Child = letra
                    };
                    Button boton = new Button
                    {
                        Content = vista

                    };

                    this.TecladoGrid.Children.Add(boton);
                    Grid.SetRow(boton, fila);
                    Grid.SetColumn(boton, columna);

                    

                }
            }
            


        }

        private void NuevaPartidaButton_Click(object sender, RoutedEventArgs e)
        {
            
            Random r = new Random();
            int posicionAleatoria =r.Next(0, palabras.Count );

            String palabra = palabras[posicionAleatoria];

            char[] letras = palabra.ToCharArray();

            foreach (char i in letras)
            {

                TextBlock letra = new TextBlock
                {
                    FontSize =60,
                    FontWeight = FontWeights.Bold,
                    Text = i.ToString(),
                    //Visibility = Visibility.Hidden,
                    Tag = i,
                    Margin = new Thickness(10)
                };
                Border bordeLetra = new Border
                {
                    Height = 30,
                    Padding = new Thickness(10),
                    Margin = new Thickness(10),
                    BorderThickness = new Thickness(0, 0, 0, 5),
                    BorderBrush = Brushes.Black,
                    Child = letra
                };

                this.PanelPalabra.Children.Add(bordeLetra);




            }           
            


            

        }
    }
}
