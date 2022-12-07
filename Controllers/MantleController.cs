using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class MantleController : Controller
    {
        private readonly IMantleRepository repo;
        public MantleController(IMantleRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index(int id)
        {
            var mantles = repo.GetAllMantles(id);
            var order = repo.GetLotNum(id);
            ViewBag.LotNum = order.LotNum;
            ViewBag.HouseID = order.HouseID;
            return View(mantles);
        }
        public IActionResult InsertMantle(int id)
        {
            ViewBag.HouseID = id;
            return View(new Mantle());
        }
        public IActionResult InsertMantleToDatabase(Mantle mantle)
        {
            repo.InsertMantle(mantle);
            return RedirectToAction("Index", new { id = mantle.HouseID });
        }
    }
}

