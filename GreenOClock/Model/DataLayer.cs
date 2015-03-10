using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GreenOClock.Model
{
    public class DataLayer
    {
        private static DataLayer _instance;
        public static DataLayer Instance
        {
            get { return _instance ?? (_instance = new DataLayer()); }
        }
        public TagRepository Tagsrepository { get; set; }
        public ActivityRepository ActivitiesRepository { get; set; }
        public UserRepository UsersRepository { get; set; }
        private GreenOClockEntities goce;

        private DataLayer()
        {
            goce = new GreenOClockEntities();
            Tagsrepository = new TagRepository(goce);
            ActivitiesRepository = new ActivityRepository(goce);
            UsersRepository = new UserRepository(goce);
        }

    }
}
