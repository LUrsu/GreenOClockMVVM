using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;

namespace GreenOClock.ViewModel
{
    class RegisterUserViewModel : ViewModelBase
    {
        public RelayCommand RegisterUserCommand { get; set; }

        public RegisterUserViewModel()
        {
            RegisterUserCommand = new RelayCommand(RegisterUser);
        }

        private void RegisterUser()
        {
            if(UserName != null && PassWord != null && Email != null)
            {
                var newUser = new User()
                                  {
                                      UserName = UserName,
                                      Email = Email,
                                      PassWord = PassWord 
                                  };
                if (DataLayer.Instance.UsersRepository.IsUserRegistered(newUser))
                {
                    DataLayer.Instance.UsersRepository.AddUser(newUser);
                    Messenger.Default.Send(new SwitchViewMessage() {ShowControl = WindowViews.Login});
                }
                else
                {
                    MessageBox.Show("that user already exists");
                }
            }
            else
            {
                MessageBox.Show("some of the fields were left empty");
            }
        }

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set 
            {
                _userName = value;
                RaisePropertyChanged("UserName");
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged("Email");
            }
        }

        private string _realName;
        public string RealName
        {
            get { return _realName; }
            set
            {
                _realName = value;
                RaisePropertyChanged("RealName");
            }
        }

        private string _passWord;
        public string PassWord
        {
            get { return _passWord; }
            set 
            {
                _passWord = value;
                RaisePropertyChanged("PassWord");
            }
        }
    }
}
