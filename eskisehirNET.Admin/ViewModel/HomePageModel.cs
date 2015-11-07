using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eskisehirNET.Admin.ViewModel
{
    public class HomePageModel
    {
        public int KullaniciSayisi { get; set; }
        public int MagazaSayisi { get; set; }
        public int ilanSayisi { get; set; }
        public int HaberSayisi { get; set; }
        public int icerikSayisi { get; set; }
        public int MekanSayisi { get; set; }
        public int VideoSayisi { get; set; }
        public int BannerSayisi { get; set; }

        public int Yeniilan { get; set; }
        public int YeniMagaza { get; set; }
        public int Yeniicerik { get; set; }
        public int YeniMekan { get; set; }
    }
}