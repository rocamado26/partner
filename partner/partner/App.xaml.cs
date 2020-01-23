using partner.Views.Reproductor;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace partner
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ReproductorView());
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
