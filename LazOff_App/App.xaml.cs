using Lazyoff_App.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lazyoff_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#6D5DCF")};

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
