using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Views;

namespace GreenOClock.ViewModel
{
    public class SwitchViewMessage : MessageBase
    {
        public WindowViews ShowControl { get; set; }
    }
}