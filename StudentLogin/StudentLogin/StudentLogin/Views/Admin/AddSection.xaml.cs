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
    public partial class AddSection : ContentPage
    {
        private static SQLiteHelper DataAccess = App.Connection;
        private int _standId;
        public AddSection(int standId)
        {
            InitializeComponent();
            _standId = standId;
            sectionList.ItemsSource = DataAccess.GetSectionItems(_standId);
        }
        protected void CreateSection(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(section.Text))
            {
                DataAccess.SaveItem(new AddSectionEntity() { SectionName = section.Text, StandardId = _standId });
                sectionList.IsVisible = true;
                addSection.IsVisible = false;
            }
        }
        protected void ShowCreatingSection(object sender, EventArgs eventArgs)
        {
            sectionList.IsVisible = false;
            addSection.IsVisible = true;
        }
        protected void GoToBack_Clicked(object sender, EventArgs e)
        {
            sectionList.IsVisible = true;
            addSection.IsVisible = false;
        }
    }
}