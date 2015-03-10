using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace GreenOClock.Model
{
    public class TimerModel
    {
        private readonly DispatcherTimer _timer;
        public event EventHandler OnTimeChange;
        public TimeSpan CurrentTime { get; set; }
        private static readonly TimeSpan _interval = new TimeSpan(0,0,0,1);

        public TimerModel()
        {
            _timer = new DispatcherTimer();
            _timer = new DispatcherTimer {Interval = _interval};
            _timer.Tick += new EventHandler(TimerTicked);
        }

        public void TimerTicked(object sender, EventArgs e)
        {
            if(OnTimeChange != null)
            {
                CurrentTime.Add(_interval);
                OnTimeChange(sender, e);
            }
        }

        public void Tick()
        {
            _timer.Start();
        }

        public void Tock()
        {
            _timer.Stop();
        }
    }
}
