using eskisehirNET.Admin.ViewModel;
using eskisehirNET.Core.infrastructure;
using System.Web.Mvc;

namespace eskisehirNET.Admin.Controllers
{
    public class HomeController : Controller
    {


        private readonly IHaberRepository _haberRepository;
        private readonly IMekanRepository _mekanRepository;
        private readonly IVideoRepository _videoRepository;
        private readonly IYasamRepository _yasamRepository;


        public HomeController(IHaberRepository haberRepository, IMekanRepository mekanRepository, IVideoRepository videoRepository, IYasamRepository yasamRepository)
        {
            _haberRepository = haberRepository;
            _mekanRepository = mekanRepository;
            _videoRepository = videoRepository;
            _yasamRepository = yasamRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            var pageModel = new HomePageModel {
                HaberSayisi = _haberRepository.Count(),
                MekanSayisi = _mekanRepository.Count(),
                VideoSayisi = _videoRepository.Count(),
                icerikSayisi = _yasamRepository.Count(),
                KullaniciSayisi = 12,
                BannerSayisi=14,
                ilanSayisi = 25,
                MagazaSayisi = 67,
                Yeniicerik = 78,
                Yeniilan = 97,
                YeniMagaza = 78,
                YeniMekan = 45

            };
            return View(pageModel);
        }
    }
}