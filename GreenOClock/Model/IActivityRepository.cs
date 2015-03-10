using System;

namespace GreenOClock.Model
{
    public interface IActivityRepository
    {
        void AddActivity(Activity addedActivity);
        void AddStartStopTimeToActivity(Activity activity, DateTime time);
        void RemoveActivity(Activity activity);
        void SetTotalTime(Activity activity, int totalTime);
    }
}