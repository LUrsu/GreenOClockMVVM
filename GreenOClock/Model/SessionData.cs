using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace GreenOClock.Model
{
    public static class SessionData
    {
        public static int UserId { get; set; }
        public static User CurrentUser { get; set; }
        public static Activity ActiveActivity { get; set; }
    }



    
}
