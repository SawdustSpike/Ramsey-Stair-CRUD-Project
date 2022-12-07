using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class TubFrontController : Controller
    {
        private readonly ITubFrontRepository repo;
        public TubFrontController(ITubFrontRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index(int id)
        {
            var TubFront = repo.GetAllTubFronts(id);
            var order = repo.GetLotNum(id);
            ViewBag.LotNum = order.LotNum;
            ViewBag.HouseID = order.HouseID;
            return View(TubFront);
        }
        public IActionResult InsertTubFront(int id)
        {
            ViewBag.HouseID = id;
            return View(new TubFront());
        }
        public IActionResult InsertTubFrontToDatabase(TubFront tubFront)
        {
            repo.InsertTubFront(tubFront);
            return RedirectToAction("Index", new { id = tubFront.HouseID });
        }
    }
}

