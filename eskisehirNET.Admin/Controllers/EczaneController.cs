using eskisehirNET.Core.infrastructure;
using eskisehirNET.Data.Model;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace eskisehirNET.Admin.Controllers
{
    public class EczaneController : Controller
    {
        private readonly IEczaneRepository _eczaneRepository;

        public EczaneController(IEczaneRepository eczaneRepository)
        {
            _eczaneRepository = eczaneRepository;
        }

        // GET: Eczane
        public ActionResult Index()
        {
            var eczaneList = _eczaneRepository.GetAll().ToList();
            return View(eczaneList);
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(Eczane eczane)
        {
            if (!ModelState.IsValid)
            {
                return View(eczane);
            }

            _eczaneRepository.Insert(eczane);
            _eczaneRepository.Save();

            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var eczane = _eczaneRepository.GetById(id.Value);
            if (eczane == null)
            {
                return HttpNotFound();
            }

            return View(eczane);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Duzenle(Eczane eczane)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            _eczaneRepository.Update(eczane);
            _eczaneRepository.Save();

            return RedirectToAction("Index");
        }
        public ActionResult Sil(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var eczane = _eczaneRepository.GetById(id.Value);

            if (eczane == null)
            {
                return HttpNotFound();
            }

            return View(eczane);
        }

        [HttpPost]
        [ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult SilConfirmed(int id)
        {
            _eczaneRepository.Delete(id);
            _eczaneRepository.Save();

            return RedirectToAction("Index");
        }
    }
}