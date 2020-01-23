using partner.ViewModels.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace partner.ViewModels.Reproductor
{
    public class ReproductorViewModel : BaseViewModel
    {

        private string linkVideo;
        public string LinkVideo
        {
            get { return linkVideo; }
            set
            {
                linkVideo = value;
                OnPropertyChanged();
            }
        }

        public void GetUrlVideo()
        {
            try
            {
                LinkVideo = "https://www.youtube.com/embed/DGRz2BJQRXU"; 
            }catch (Exception ex)
            {

            }
        }

        private readonly static ReproductorViewModel instance = new ReproductorViewModel();
        public static ReproductorViewModel Instance
        {
            get { return instance; }
        }

    }
}
