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

namespace task_5_idle_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int i;
        public MainWindow()
        {
            InitializeComponent();

            i = 0;
        }

        private void Batton_Click_1(object sender, MouseButtonEventArgs e)
        {
            i++;
            Texbox.Text = "Click " + i;
        }


        private void Button_zanovo(object sender, MouseButtonEventArgs e)
        {
            i = 0;
            Texbox.Text = "Click ";
        }
    }
}
