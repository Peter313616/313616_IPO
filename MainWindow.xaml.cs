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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _313616_IPO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            decimal length = 0;
            decimal Width = 0;
            decimal Area = 0;

            decimal.TryParse(txtLength.Text, out length);
            decimal.TryParse(txtWidth.Text, out Width);

            Area = length * Width;
            lblOutput.Content = "The Area is " + Area.ToString("#.00");
        }
    }
}
