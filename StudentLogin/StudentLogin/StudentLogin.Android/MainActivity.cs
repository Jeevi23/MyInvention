using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


namespace StudentLogin.Droid
{
    [Activity(Label = "StudentLogin", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            AppCenter.Start("68bd10fa-297b-4365-a1cf-abee6a305e45",
                   typeof(Analytics), typeof(Crashes));
            AppCenter.Start("68bd10fa-297b-4365-a1cf-abee6a305e45", typeof(Analytics), typeof(Crashes));
            Crashes.GenerateTestCrash();
          
            LoadApplication(new App());
        }
    }
}

