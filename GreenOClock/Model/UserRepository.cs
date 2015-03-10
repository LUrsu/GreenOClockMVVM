using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Windows;
using NexRepository;

namespace GreenOClock.Model
{
    public class UserRepository : Repository<GreenOClockEntities, User>, IUserRepository
    {
        public UserRepository(GreenOClockEntities context) : base(context)
        {
        }

        public bool LogIn(string userName, string passWord)
        {
            return All().Where(p => p.UserName == userName && p.PassWord == passWord).Count() == 1;
        }

        public void AddUser(User user)
        {
            Save(user);
        }

        public bool IsUserRegistered(User suspectUser)
        {
            return
                All().Where(
                    p =>
                    p.PassWord == suspectUser.PassWord && p.Email == suspectUser.Email &&
                    p.UserName == suspectUser.UserName).Count() <= 0;
        }

        public User GetUserObject(string userName, string passWord)
        {
            var user = All().Where(u => u.UserName == userName && u.PassWord == passWord).Single();
            return user;
        }
    }
}
