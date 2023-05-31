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

namespace AlgTrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FunnyAlgorithmText();
        }

        double timer;

        async void FunnyAlgorithmText()
        {
            while (true)
            {
                await Task.Delay(10);
                timer += 0.1;
                Algorithm.FontSize = 20 + Math.Sin(timer) * 3;
            }
        }
    }
}
