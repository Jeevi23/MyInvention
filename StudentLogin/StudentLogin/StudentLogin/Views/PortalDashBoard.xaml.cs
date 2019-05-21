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
    public partial class PortalDashBoard : MasterDetailPage
    {
        public PortalDashBoard()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as PortalDashBoardMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
           
            if (item.Title == "RoleType")
                page = new Admin.AddRoleType();
            else if (item.Title == "Standard")
                page = new Admin.AddStandardPage();

            page.Title = item.Title;
            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}