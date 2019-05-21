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
    public partial class AddStandardPage : ContentPage
    {
        private static SQLiteHelper DataAccess = App.Connection;
        public AddStandardPage()
        {
            InitializeComponent();
            standardList.ItemsSource = DataAccess.GetStandardItems();
        }
        protected void StandardItem_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            var selectedItem = e.SelectedItem as StandardEntity;
            Navigation.PushAsync(new AddSection(selectedItem.StandardId));
            ((ListView)sender).SelectedItem = null;
        }
        protected void AddStandardClass(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(role.Text))
            {
                DataAccess.SaveItem(new StandardEntity() { StandardClass = role.Text });
                standardList.IsVisible = true;
                addStandard.IsVisible = false;
            }           
        }        
        protected void ShowNewStandard(object sender,EventArgs eventArgs)
        {
            standardList.IsVisible = false;
            addStandard.IsVisible = true;
        }
        protected void GoToBack_Clicked(object sender, EventArgs e)
        {
            standardList.IsVisible = true;
            addStandard.IsVisible = false;
        }
    }
}