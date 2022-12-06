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
        public IActionResult Index()
        {
            var rails = repo.GetAllRails();
            return View(rails);
        }
        public IActionResult InsertRailToDatabase(Rail railToInsert)
        {
            repo.InsertRail(railToInsert);
            return RedirectToAction("Index");
        }
        public IActionResult InsertRail()
        {
            ViewBag.RailStyles = repo.GetRailStyle();
            ViewBag.RailTypes = repo.GetRailType();
            ViewBag.CapTypes = repo.GetCapType();
            
            
            return View(new Rail());
        }
    }
}
