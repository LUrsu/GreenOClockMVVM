using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GreenOClock.Model;

namespace GreenOClock
{
    static class Timer
    {
       
        public static void Start(TimeSpan updateInterval)
        {
            _updateInterval = updateInterval;
            new Thread(TimerLoop).Start();
        }

        private static TimeSpan _updateInterval;

        public static bool IsActive { get; set; }

        private static void TimerLoop()
        {
            while (IsActive)
            {
                new Thread(FireEvent).Start();
                Thread.Sleep(_updateInterval);
            }
        }

        private static void FireEvent()
        {
            // fire the event here with TimerEventArgs
            CallShit(new TimerEventArgs(DateTime.Now, _updateInterval));
        }


        // make a static event
        public delegate void Shit(TimerEventArgs t);

        public static event Shit CallShit;
    }

    public class TimerEventArgs : EventArgs
    {
        public TimerEventArgs(DateTime currentTime, TimeSpan timeSpan/*, and any others that you make for properties*/)
        {
            CurrentTime = currentTime;
            TimeSpan = timeSpan;
            // those params for the properties
        }

        public DateTime CurrentTime { get; set; }
        public TimeSpan TimeSpan { get; set; }
        // any extra args
    }

    
}
