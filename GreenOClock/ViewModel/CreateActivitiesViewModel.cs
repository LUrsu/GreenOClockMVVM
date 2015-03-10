using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GreenOClock.Model;
using GreenOClock.Views;

namespace GreenOClock.ViewModel
{
    public class CreateActivityViewModel : ViewModelBase
    {
        public RelayCommand AddActivityCommand { get; set; }

        public CreateActivityViewModel()
        {
            AddActivityCommand = new RelayCommand(dojjj);
        }

        public void CreateActivity(IActivity newActivity)
        {
            SessionData.CurrentUser.AllUsersActivity
        }

        public void dojjj()
        {
            
        }
    }
}
