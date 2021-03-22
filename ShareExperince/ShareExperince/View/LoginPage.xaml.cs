using ShareExperince.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShareExperince.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }
    }
}