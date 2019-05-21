using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardMaster : ContentPage
    {
        public ListView ListView;

        public DashBoardMaster()
        {
            InitializeComponent();

            BindingContext = new DashBoardMasterViewModel();
            ListView = MenuItemsListView;
        }

        class DashBoardMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<DashBoardMenuItem> MenuItems { get; set; }

            public DashBoardMasterViewModel()
            {
                MenuItems = new ObservableCollection<DashBoardMenuItem>(new[]
                {
                    new DashBoardMenuItem { Id = 0, Title = "Page 1" },
                    new DashBoardMenuItem { Id = 1, Title = "Page 2" },
                    new DashBoardMenuItem { Id = 2, Title = "Page 3" },
                    new DashBoardMenuItem { Id = 3, Title = "Page 4" },
                    new DashBoardMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}