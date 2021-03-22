using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShareExperince.ViewModel
{
    class UserRatingPageViewModel
    {
        public UserRatingPageViewModel()
        {
                
        }
        public ICommand SubmitCommand => new Command(async () => await Submit());
        private async Task Submit()
        {
            
            (Application.Current as App).MainPage.DisplayAlert("UserRating", "Thanks for your feedback", "OK");
        }
    }
}
