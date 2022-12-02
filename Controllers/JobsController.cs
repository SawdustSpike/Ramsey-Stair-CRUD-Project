using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class JobsController : Controller
    {
        private readonly ICatchAll repo;


        public JobsController(ICatchAll repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
