using System.Linq;
using System.Web.Mvc;
using yeniBingöl.Models;

namespace yeniBingöl.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly CityDataContext _context;

        public AdminController()
        {
            _context = new CityDataContext();
        }

        // İlçeler listesi
        public ActionResult Index()
        {
            var model = new CityViewModel
            {
                Ilceler = _context.Ilceler.ToList(),
                NufusBilgi = _context.NufusBilgi.ToList()
            };
            return View(model);
        }


        // Yeni ilçe ekleme
        public ActionResult AddIlce()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddIlce(Ilceler ilce)
        {
            if (ModelState.IsValid)
            {
                _context.Ilceler.Add(ilce);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ilce);
        }

        // İlçe silme: Silme onayı sayfası
        public ActionResult DeleteIlce(int id)
        {
            var ilce = _context.Ilceler.Find(id);
            if (ilce == null) return HttpNotFound();
            return View(ilce);
        }

        [HttpPost, ActionName("DeleteIlce")]
        public ActionResult DeleteIlceConfirmed(int id)
        {
            var ilce = _context.Ilceler.Find(id);
            if (ilce != null)
            {
                _context.Ilceler.Remove(ilce);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // İlçe düzenleme
        public ActionResult EditIlce(int id)
        {
            var ilce = _context.Ilceler.Find(id);
            if (ilce == null) return HttpNotFound();
            return View(ilce);
        }

        [HttpPost]
        public ActionResult EditIlce(Ilceler ilce)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(ilce).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ilce);
        }

        // Yeni nüfus kaydı ekleme
        public ActionResult AddPopulation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPopulation(NufusBilgi nufus)
        {
            if (ModelState.IsValid)
            {
                _context.NufusBilgi.Add(nufus);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nufus);
        }

        // Nüfus düzenleme
        public ActionResult EditPopulation(int id)
        {
            var nufus = _context.NufusBilgi.Find(id);
            if (nufus == null) return HttpNotFound();
            return View(nufus);
        }

        [HttpPost]
        public ActionResult EditPopulation(NufusBilgi nufus)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(nufus).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nufus);
        }

        // Nüfus silme: Silme onayı sayfası
        public ActionResult DeletePopulation(int id)
        {
            var nufus = _context.NufusBilgi.Find(id);
            if (nufus == null) return HttpNotFound();
            return View(nufus);
        }

        [HttpPost, ActionName("DeletePopulation")]
        public ActionResult DeletePopulationConfirmed(int id)
        {
            var nufus = _context.NufusBilgi.Find(id);
            if (nufus != null)
            {
                _context.NufusBilgi.Remove(nufus);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
