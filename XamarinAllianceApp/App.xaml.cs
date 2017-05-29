using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;
using XamarinAllianceApp.Views;

namespace XamarinAllianceApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // The root page of your application
            MainPage = new NavigationPage(new CharacterListPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start("android=fa6214be-0c25-4f0b-b314-402b3b3c4db5;",
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
