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

namespace PruebaVistas
{
    /// <summary>
    /// Lógica de interacción para VentanaHija.xaml
    /// </summary>
    public partial class VentanaHija : Window
    {
        private VentanaHijaVM vm;
        public VentanaHija()
        {
            InitializeComponent();
            vm = new VentanaHijaVM();
            this.DataContext = vm;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
