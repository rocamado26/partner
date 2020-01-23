using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
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
            AppCenter.Start("android=28311123-021c-4d97-ae31-22e3e8362d8e; ios=3087c8ab-a949-44e3-834f-8154e19a55d7",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
