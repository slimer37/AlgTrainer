using System;
using System.Windows.Threading;
using System.Windows.Controls;

namespace AlgTrainer
{
    public class AlgTimer
    {
        DispatcherTimer _timer;
        TimeSpan _elapsedTime;

        TextBlock _textBlock;

        public AlgTimer(TextBlock textBlock)
        {
            _textBlock = textBlock;

            _timer = new DispatcherTimer();

            _timer.Tick += Tick;

            _timer.Interval = new TimeSpan(0, 0, 0, 0, 10);

            ResetTime();
        }

        private void Tick(object? sender, EventArgs e)
        {
            _elapsedTime = _elapsedTime.Add(_timer.Interval);

            _textBlock.Text = _elapsedTime.ToString(@"ss\.ff");
        }

        private void ResetTime() => _elapsedTime = new TimeSpan();

        public void ToggleTimer()
        {
            if (!_timer.IsEnabled)
            {
                ResetTime();
                _timer.Start();
            }
            else
            {
                _timer.Stop();
            }
        }
    }
}
