using Microsoft.AspNetCore.Mvc;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class RailController : Controller
    {
        //private readonly IRailRepository repo;

        //public ProductController(IProductRepository repo)
        //{
        //    this.repo = repo;
        //}
        public IActionResult Index()
        {
            return View();
        }
    }
}
