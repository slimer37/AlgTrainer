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
        DispatcherTimer timer;
        TimeSpan elapsedTime;
        double funnyTimer;

        public MainWindow()
        {
            InitializeComponent();

            FunnyAlgorithmText();

            KeyDown += OnKeyDown;

            timer = new DispatcherTimer();

            timer.Tick += Timer_Tick;

            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);

            elapsedTime = new TimeSpan();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(timer.Interval);
            Timer.Text = elapsedTime.ToString(@"ss\.ff");
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Space:
                    ToggleTimer();
                    break;
            }
        }

        private void ToggleTimer()
        {
            if (!timer.IsEnabled)
            {
                elapsedTime = new TimeSpan();
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private async void FunnyAlgorithmText()
        {
            while (true)
            {
                await Task.Delay(10);
                funnyTimer += 0.1;
                Algorithm.FontSize = 20 + Math.Sin(funnyTimer) * 3;
            }
        }
    }
}
