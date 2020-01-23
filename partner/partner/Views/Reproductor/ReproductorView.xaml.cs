using partner.ViewModels.Reproductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace partner.Views.Reproductor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReproductorView : ContentPage
    {
        public ReproductorView()
        {
            InitializeComponent();
            BindingContext = ReproductorViewModel.Instance;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ReproductorViewModel.Instance.GetUrlVideo();
        }
    }
}