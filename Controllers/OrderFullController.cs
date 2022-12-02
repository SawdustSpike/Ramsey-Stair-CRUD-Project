using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class OrderFullController : Controller
    {
        private readonly IOrderFullRepository repo;

        public OrderFullController(IOrderFullRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var order = repo.GetAllOrderFull();
            return View(order);
        }

        public IActionResult FullOrder(int id)
        {
            var order = repo.FullOrder(id);
            return View(order);
        }
        //public IActionResult InsertOrderToDatabase(OrderFull orderToInsert)
        //{
        //    repo.InsertOrderFull(orderToInsert);
        //    return RedirectToAction("Index");
        //}
        //public IActionResult InsertRail()
        //{
        //    ViewBag.RailStyles = repo.GetRailStyle();
        //    ViewBag.RailTypes = repo.GetRailType();
        //    ViewBag.CapTypes = repo.GetCapType();
        //    ViewBag.LotNumbers = repo.GetLotNumbers();
        //    ViewBag.Builders = repo.GetBuilders();
        //    ViewBag.BalusterTypes = repo.GetBalusterTypes();


        //    return View(new Rail());
        //}
    }
}
