using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;

namespace GreenOClock.Model
{
    public interface IUserRepository
    {
        bool LogIn(string userName, string passWord);
        void AddUser(User user);
        bool IsUserRegistered(User suspectUser);
        User GetUserObject(string userName, string passWord);
    }
}