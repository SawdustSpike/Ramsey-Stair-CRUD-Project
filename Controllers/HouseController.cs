using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Repos;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class HouseController : Controller
    {
        private readonly IHouseRepository repo;

        public HouseController(IHouseRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var houses = repo.GetAllHouses();
            return View(houses);
        }

    }
}
