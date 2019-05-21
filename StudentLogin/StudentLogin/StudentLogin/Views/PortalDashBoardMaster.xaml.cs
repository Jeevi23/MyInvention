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
    public partial class PortalDashBoardMaster : ContentPage
    {
        public ListView ListView;

        public PortalDashBoardMaster()
        {
            InitializeComponent();

            BindingContext = new PortalDashBoardMasterViewModel();
            ListView = MenuItemsListView;
        }

        class PortalDashBoardMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PortalDashBoardMenuItem> MenuItems { get; set; }

            public PortalDashBoardMasterViewModel()
            {
                MenuItems = new ObservableCollection<PortalDashBoardMenuItem>(new[]
                {
                    new PortalDashBoardMenuItem { Id = 0, Title = "RoleType" },
                    new PortalDashBoardMenuItem { Id = 1, Title = "Standard" },
                    new PortalDashBoardMenuItem { Id = 2, Title = "Page 3" },
                    new PortalDashBoardMenuItem { Id = 3, Title = "Page 4" },
                    new PortalDashBoardMenuItem { Id = 4, Title = "Page 5" },
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