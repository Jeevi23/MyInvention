using StudentLogin_MVVM.Entity;
using StudentLogin_MVVM.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentLogin.Views.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddRoleType : ContentPage
    {
        public AddRoleType()
        {
            InitializeComponent();
            
        }
        protected void NewRoleType(object sender,EventArgs e)
        {
            var roleType = new RoleTypeEntity()
            {
                RoleName =role.Text
            };
            GlobalValue.Connection.SaveItem(roleType);
            App.Current.MainPage = new RegistrationPage();
        }
    }
}