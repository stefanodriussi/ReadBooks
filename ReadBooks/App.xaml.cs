using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReadBooks.Services;
using ReadBooks.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace ReadBooks
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("ios=1e072c37-fbf9-495a-ba9e-f51834fb335f;" +
                  "android=5c1384e6-7745-485a-b249-e914e6aa6479",
                  typeof(Analytics), typeof(Crashes));
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
