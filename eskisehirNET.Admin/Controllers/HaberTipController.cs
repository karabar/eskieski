using eskisehirNET.Core.infrastructure;
using eskisehirNET.Data.Model;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace eskisehirNET.Admin.Controllers
{
    public class HaberTipController : Controller
    {
        private readonly IHaberTipRepository _haberTipRepository;

        public HaberTipController(IHaberTipRepository haberTipRepository)
        {
            _haberTipRepository = haberTipRepository;

        }

        // GET: HaberTip
        public ActionResult Index()
        {
            var tipList = _haberTipRepository.GetAll().ToList();
            return View(tipList);
        }
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(HaberTip habertip)
        {
            if (!ModelState.IsValid)
            {
                return View(habertip);
            }

            _haberTipRepository.Insert(habertip);
            _haberTipRepository.Save();

            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var habertipi = _haberTipRepository.GetById(id.Value);
            if (habertipi == null)
            {
                return HttpNotFound();
            }

            return View(habertipi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Duzenle(HaberTip habertip)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            _haberTipRepository.Update(habertip);
            _haberTipRepository.Save();

            return RedirectToAction("Index");
        }

        public ActionResult Sil(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var habertip = _haberTipRepository.GetById(id.Value);

            if (habertip == null)
            {
                return HttpNotFound();
            }

            return View(habertip);
        }

        [HttpPost]
        [ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult SilConfirmed(int id)
        {
            _haberTipRepository.Delete(id);
            _haberTipRepository.Save();

            return RedirectToAction("Index");
        }
    }
}