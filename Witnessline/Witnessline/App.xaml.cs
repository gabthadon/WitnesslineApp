using System;
using Witnessline.Services;
using Witnessline.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Witnessline
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LandingPage();
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
