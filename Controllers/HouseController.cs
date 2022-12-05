using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class HouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IHouseRepository repo;

        public HouseController(IHouseRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult CreateNewHouse(House house)
        {
            repo.InsertHouse(house);
            return RedirectToAction("Index");
        }
        public IActionResult EditLotNum(House house)
        {
            repo.UpdateHouse(house);
            return RedirectToAction("Index");
        }
        public IActionResult EditHouse(House house)
        {
            return RedirectToAction("index");
        }
    }
}
