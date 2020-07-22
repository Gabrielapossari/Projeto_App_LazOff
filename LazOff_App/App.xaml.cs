using LazOff_App.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LazOff_App
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
