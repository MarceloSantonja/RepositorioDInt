﻿using System;
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
using System.Windows.Shapes;

namespace GestionPersonasU6A2
{
    /// <summary>
    /// Lógica de interacción para AddNacionalidadWindow.xaml
    /// </summary>
    public partial class AddNacionalidadWindow : Window
    {
        public AddNacionalidadWindow()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;

        }
    }
}
