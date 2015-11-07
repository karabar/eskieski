using eskisehirNET.Core.infrastructure;
using eskisehirNET.Data.Model;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace eskisehirNET.Admin.Controllers
{

    public class HaberController : Controller
    {
        private readonly IHaberRepository _haberRepository;
        private readonly IHaberTipRepository _haberTipRepository;
        private readonly IHaberKategoriRepository _haberKategoriRepository;

        public HaberController(IHaberRepository haberRepository, IHaberTipRepository haberTipRepository, IHaberKategoriRepository haberKategoriRepository)
        {
            _haberRepository = haberRepository;
            _haberTipRepository = haberTipRepository;
            _haberKategoriRepository = haberKategoriRepository;
        }

        // GET: Haber
        public ActionResult Index()
        {
            var haberList = _haberRepository.GetAll().ToList();
            return View(haberList);
        }

        public ActionResult Ekle()
        {
            SetHaberTip();
            SetHaberKategori();
            return View();
        }
        private void SetHaberTip(object habertip = null)
        {
            var habertipList = _haberTipRepository.GetAll().ToList();
            var haberTipselectList = new SelectList(habertipList, "HaberTipID", "HaberTipi", habertip);
            ViewData.Add("HaberTipID", haberTipselectList);
        }
        private void SetHaberKategori(object haberkategori = null)
        {
            var haberkategoriList = _haberKategoriRepository.GetAll().ToList();
            var haberKategoriselectList = new SelectList(haberkategoriList, "HaberKategoriID", "KategoriAdi", haberkategori);
            ViewData.Add("HaberKategoriID", haberKategoriselectList);
        }
    }
}