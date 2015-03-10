using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;

namespace GreenOClock.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        public RelayCommand LoginCommand { get; set; }
        public RelayCommand RegisterUserCommand { get; set; }

        public delegate void InitializeProperties();

        public static event InitializeProperties InitializePropertiesEvent;


        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
            RegisterUserCommand = new RelayCommand(RegisterUser);
            
        }

        private void RegisterUser()
        {
            Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.RegisterUser });
        }

        private void Login()
        {
            var users = DataLayer.Instance.UsersRepository;
           if(users.LogIn(UserName, PassWord))
           {
               var currentUser = users.GetUserObject(UserName, PassWord);
               InitializeSession(currentUser);
               Messenger.Default.Send(new LoadUserMessage() {UserName = currentUser.UserName});
               Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.HomePage });
           }
           else
           {
               MessageBox.Show("your login information is incorect");
           }
            UserName = string.Empty;
            PassWord = string.Empty;
        }

        private void InitializeSession(User currentUser)
        {
            SessionData.CurrentUser = currentUser;
            SessionData.UserId = currentUser.UserId;
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
