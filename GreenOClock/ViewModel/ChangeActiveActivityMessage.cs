using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Messaging;

namespace GreenOClock.ViewModel
{
    public class ChangeActiveActivityMessage : MessageBase
    {
        public Activity ActiveActivity { get; set; }
    }
}
