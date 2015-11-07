using eskisehirNET.Core.infrastructure;
using eskisehirNET.Data.Model;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace eskisehirNET.Admin.Controllers
{
    public class HaberKategoriController : Controller
    {
        private readonly IHaberKategoriRepository _haberKategoriRepository;

        public HaberKategoriController(IHaberKategoriRepository haberKategoriRepository)
        {
            _haberKategoriRepository = haberKategoriRepository;
        }
        // GET: HaberKategori
        public ActionResult Index()
        {
            var kategoriList = _haberKategoriRepository.GetAll().ToList();
            return View(kategoriList);
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(HaberKategori haberKategori) 
        {
            if(!ModelState.IsValid)
            {
                return View(haberKategori);
            }

            _haberKategoriRepository.Insert(haberKategori);
            _haberKategoriRepository.Save();

            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var haberkategori = _haberKategoriRepository.GetById(id.Value);
            if(haberkategori == null)
            {
                return HttpNotFound();
            }

            return View(haberkategori);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Duzenle(HaberKategori haberKategori)
        {
            if(!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            _haberKategoriRepository.Update(haberKategori);
            _haberKategoriRepository.Save();

            return RedirectToAction("Index");
        }

        public ActionResult Sil(int? id)
        {
            if(id ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var haberkategori = _haberKategoriRepository.GetById(id.Value);

            if (haberkategori == null)
            {
                return HttpNotFound();
            }

            return View(haberkategori);
        }

        [HttpPost]
        [ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult SilConfirmed (int id)
        {
            _haberKategoriRepository.Delete(id);
            _haberKategoriRepository.Save();

            return RedirectToAction("Index");
        }
    }
}