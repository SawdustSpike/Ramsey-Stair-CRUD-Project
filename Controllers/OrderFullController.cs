using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X509;
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
        public IActionResult CreateNewHouse()
        {
            var order = new OrderFull();
            return View(order);
        }
        public IActionResult DeleteOrderFull(OrderFull order)
        {
            repo.DeleteOrderFull(order);
            return RedirectToAction("Index");
        }
        public IActionResult EditHouseDetails(OrderFull order)
        {
            ViewBag.Builders = repo.GetBuilders();
            return RedirectToAction("Index");
        }
        public IActionResult EditMenu(int id)
        {
            var order = repo.GetOrderFull(id);
            return View(order);
        }
        public IActionResult EditLotNum(int id)
        {
            var order = repo.GetOrderFull(id);
            return RedirectToAction("EditMenu", new { id = id });
        }
        public IActionResult FullOrder(int id)
        {
            var order = repo.FullOrder(id);
            ViewBag.RailStyles = repo.GetRailStyle();
            ViewBag.RailTypes = repo.GetRailType();
            ViewBag.CapTypes = repo.GetCapType();
            ViewBag.Builders = repo.GetBuilders();
            ViewBag.BalusterTypes = repo.GetBalusterTypes();
            order.Railines = repo.GetAllRail(id);
            order.Mantles = repo.GetMantles(id);
            order.TubFronts = repo.GetTubFronts(id);
            order.WallAccesses = repo.GetWallAccesses(id);
            order.Niches = repo.GetNiches(id);

            return View(order);
        }
        public IActionResult Index()
        {
           
            var order = repo.GetAllOrderFull();

            return View(order);
        }     
        public IActionResult InsertHouseToDatabase(OrderFull order)
        {
            repo.InsertHouse(order);            
            return RedirectToAction("EditMenu", new { id = repo.GetHouseID(order.LotNum) });
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
