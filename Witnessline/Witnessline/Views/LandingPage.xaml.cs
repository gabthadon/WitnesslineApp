
using System;

using System.Threading.Tasks ;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Witnessline.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();

          
        }

        protected async  override void OnAppearing()
        {
            base.OnAppearing();


            await Task.Delay(2000);

            App.Current.MainPage = new AppShell();
        }
    }
}