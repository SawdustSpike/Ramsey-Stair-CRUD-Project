using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class RailController : Controller
    {
        private readonly IRailRepository repo;

        public RailController(IRailRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index(int id)
        {
            var order = repo.GetLotNum(id);
            var rails = repo.GetAllRails(id);
            ViewBag.LotNum = order.LotNum;
            ViewBag.HouseID = order.HouseID;
            return View(rails);
        }
        public IActionResult InsertRailToDatabase(Rail railToInsert)
        {
            repo.InsertRail(railToInsert);
            return RedirectToAction("Index", new {id = railToInsert.HouseID});
        }
        public IActionResult InsertRail(int id)
        {
            ViewBag.RailStyles = repo.GetRailStyle();
            ViewBag.RailTypes = repo.GetRailType();
            ViewBag.CapTypes = repo.GetCapType();
            ViewBag.HouseID = id;
            
            return View(new Rail());
        }
    }
}
