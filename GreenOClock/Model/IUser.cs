using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenOClock.Model
{
    public interface IUser
    {
         string ScreenName { get; set; }
         string PassWord { get; set; }
         string RealName { get; set; }
         string Email { get; set; }
         IActivity CurrentTimedActivity { get; set; }
         IEnumerable<IActivity> AllUsersActivity { get; set; }
         int UserId { get; set; }
    }
}
