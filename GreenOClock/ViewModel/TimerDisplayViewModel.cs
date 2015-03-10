using System;
using GalaSoft.MvvmLight;
using GreenOClock.Model;

namespace GreenOClock.ViewModel
{
    public class TimerDisplayViewModel : ViewModelBase
    {
        private TimerModel Timer;

        private int _secondCount;
        public int SecondCount
        {
            get { return _secondCount; }
            set
            {
                _secondCount = value;
                RaisePropertyChanged("SecondCount");
            }
        }

        private int _minuteCount;
        public int MinuteCount
        {
            get { return _minuteCount; }
            set
            {
                _minuteCount = value;
                RaisePropertyChanged("MinuteCount");
            }
        }

        private int _hourCount;
        public int HourCount
        {
            get { return _hourCount; }
            set
            {
                _hourCount = value;
                RaisePropertyChanged("HourCount");
            }
        }

        public void TimeChanged(object sender,EventArgs e)
        {
            SecondCount = Timer.CurrentTime.Seconds;
            MinuteCount = Timer.CurrentTime.Minutes;
            HourCount = Timer.CurrentTime.Hours;
        }

        public TimerDisplayViewModel()
        {
            SecondCount = 0;
            MinuteCount = 0;
            HourCount = 0;
            Timer = new TimerModel();
            Timer.OnTimeChange += new EventHandler(TimeChanged);
        }

    }
}
