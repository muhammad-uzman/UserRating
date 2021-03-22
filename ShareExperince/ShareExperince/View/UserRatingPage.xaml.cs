using ShareExperince.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShareExperince.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserRatingPage : ContentPage
    {
        public UserRatingPage()
        {
            InitializeComponent();
            BindingContext = new UserRatingPageViewModel();

        }
    }
}