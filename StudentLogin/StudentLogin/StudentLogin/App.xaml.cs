
using StudentLogin_MVVM.Helper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace StudentLogin
{
    public partial class App : Application
    {
        private static SQLiteHelper _connection;

        public static SQLiteHelper Connection
        {
            get
            {
                if (_connection == null)
                    return _connection = new SQLiteHelper();
                else
                    return _connection;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new StudentLogin.Views.StudentLoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
