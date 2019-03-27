using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace StudentLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var properties = new Dictionary<string, string> { { "Appcenter", "TrackIssue" } };
            Crashes.TrackError(new Exception(), properties);
        }
    }
}
