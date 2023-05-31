using System;
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
using System.Windows.Threading;

namespace AlgTrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double _funnyTimer;

        AlgTimer _algTimer;

        public MainWindow()
        {
            InitializeComponent();

            FunnyAlgorithmText();

            KeyDown += OnKeyDown;

            _algTimer = new AlgTimer(Timer, TimeHistory);
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Space:
                    _algTimer.ToggleTimer();
                    break;
            }
        }

        private async void FunnyAlgorithmText()
        {
            while (true)
            {
                await Task.Delay(10);
                _funnyTimer += 0.1;
                Algorithm.FontSize = 20 + Math.Sin(_funnyTimer) * 3;
            }
        }
    }
}
