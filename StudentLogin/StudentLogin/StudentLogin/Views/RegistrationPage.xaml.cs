using StudentLogin_MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        private LoginViewModel _loginViewModel;
        public RegistrationPage()
        {
            InitializeComponent();
            _loginViewModel = new LoginViewModel();
        
            BindingContext = _loginViewModel;
        }
        protected void PortalRegistration(object sender,EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtfname.Text))
            {
                _loginViewModel.AddNewPortalMember();
                Navigation.PushModalAsync(new PortalDashBoard());
            }
            else
                DisplayAlert("Fail", "Login Failed", "OK", "cancel");
        }
    }
}