using ShareExperince.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShareExperince.ViewModel
{
   public class LoginPageViewModel:BaseViewModel
    {
        #region PrivateProperties
        private string _email;
        private string _password;
        #endregion
        #region PublicProperties
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                NotifyPropertyChanged();
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                NotifyPropertyChanged();
            }
        }
        #endregion
        public LoginPageViewModel()
        {

        }
        #region Commands
        public ICommand LoginCommand => new Command(async () => await Login());
        #endregion
        #region Methods
        public async Task Login()
        {
            if(Email=="abc@gmail.com" && Password=="abc123")
            {
                (Application.Current as App).MainPage.Navigation.PushAsync(new UserRatingPage());
            }
            else
            {
                (Application.Current as App).MainPage.DisplayAlert("Failed", "Incorrect Email or Password", "OK");

            }
        }
        #endregion
    }
}
