using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class NicheController : Controller
    {
        private readonly INicheRepository repo;
        public NicheController(INicheRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index(int id)
        {
            var niche = repo.GetAllNiches(id);
            var order = repo.GetLotNum(id);
            ViewBag.LotNum = order.LotNum;
            ViewBag.HouseID = order.HouseID;
            return View(niche);
        }
        public IActionResult InsertNiche(int id)
        {
            ViewBag.HouseID = id;
            return View(new Niche());
        }
        public IActionResult InsertNicheToDatabase(Niche niche)
        {
            repo.InsertNiche(niche);
            return RedirectToAction("Index", new { id = niche.HouseID });
        }
    }
}
