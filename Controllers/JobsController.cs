using Microsoft.AspNetCore.Mvc;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class JobsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
