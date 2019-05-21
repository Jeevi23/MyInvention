using StudentLogin_MVVM.Helper;
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
    public partial class StudentLoginPage : ContentPage
    {
        public StudentLoginPage()
        {
            InitializeComponent();
        }
        public void Login_Clicked(object sender,EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtuserid.Text) && !string.IsNullOrEmpty(txtpassword.Text))
            {              
                var userDetails = App.Connection.GetUserDetails(txtuserid.Text, txtpassword.Text);
                if (userDetails != null)               
                    Navigation.PushModalAsync(new PortalDashBoard());
               else
                    DisplayAlert("Login Failed", "Please Check! Data not found", "OK");
            }
            else
            {
                DisplayAlert("Login Failed", "Provide details for login", "OK");
            }

        }
    }
}