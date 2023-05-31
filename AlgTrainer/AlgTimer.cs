using System;
using System.Windows.Threading;
using System.Windows.Controls;

namespace AlgTrainer
{
    public class AlgTimer
    {
        DispatcherTimer _timer;

        DateTime _startTime;

        TextBlock _timeText;
        TextBlock _historyText;

        string FormattedTime => (DateTime.UtcNow - _startTime).ToString(@"ss\.ff");

        public AlgTimer(TextBlock timeText, TextBlock historyText)
        {
            _timeText = timeText;
            _historyText = historyText;

            _timer = new DispatcherTimer();

            _timer.Tick += Tick;

            _timer.Interval = new TimeSpan(0, 0, 0, 0, 10);

            ResetTime();
        }

        private void Tick(object? sender, EventArgs e) => _timeText.Text = FormattedTime;

        private void ResetTime() => _startTime = DateTime.UtcNow;

        public void ToggleTimer()
        {
            if (!_timer.IsEnabled)
            {
                ResetTime();

                _timer.Start();
            }
            else
            {
                _historyText.Text += FormattedTime + '\n';

                _timer.Stop();
            }
        }
    }
}
