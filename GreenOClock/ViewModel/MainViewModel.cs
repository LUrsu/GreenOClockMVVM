using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;
using GreenOClock.Views;

namespace GreenOClock.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        //public static TimerModel TimerModel { get; set; }
        //public MainViewModel()
        //{
        //    TimerModel = new TimerModel();
        //}

        //public WindowFrameView WindowPage { get; set; }

        public MainViewModel()
        {
            //InitializeComponent();
            //Closing += (s, e) => ViewModelLocator.Cleanup();

            RegisterEntities();

            Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.Welcome});
        }

        public void RegisterEntities()
        {
            Messenger.Default.Register<SwitchViewMessage>(this, SwitchView);
        }

        public void Switchview(SwitchViewMessage message)
        {
            //yum
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}

        public System.Action<SwitchViewMessage> SwitchView { get; set; }
    }
}