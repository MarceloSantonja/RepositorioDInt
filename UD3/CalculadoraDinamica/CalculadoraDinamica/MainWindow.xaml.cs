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

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock numero;
            Viewbox vista;
            Button boton;
            int valorNumero = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    valorNumero++;
                    numero = new TextBlock
                    {
                        Text = valorNumero.ToString()
                    };
                    vista = new Viewbox
                    {
                        Child = numero
                    };
                    boton = new Button
                    {
                        Content = vista,
                        Tag = valorNumero.ToString()
                    };
                    this.CalculadorGrid.Children.Add(boton);
                    Grid.SetRow(boton, (i + 2));
                    Grid.SetColumn(boton, x);
                }

            }

        }
        private void Buton_Click(object sender, RoutedEventArgs e)
        {
            var boton = (Button)sender;
            StringBuilder textoSB = new StringBuilder(TextoTextBlock.Text.ToString()).
                Append(boton.Tag.ToString());
            TextoTextBlock.Text = textoSB.ToString();

        }
    }
}
