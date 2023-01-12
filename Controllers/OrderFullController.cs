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
        public IActionResult CreateHouseToDatabase(OrderFull order)
        {
            repo.InsertHouse(order);
            return RedirectToAction("EditMenu", new { id = repo.GetHouseID(order.LotNum) });
        }
        public IActionResult DeleteOrderFull(OrderFull order)
        {
            repo.DeleteOrderFull(order);
            return RedirectToAction("Index");
        }
        public IActionResult EditHouseDetails(int id)
        {
            var order = repo.GetOrderFull(id);
            ViewBag.Builders = repo.GetBuilders();

            return View(order);
        }
        public IActionResult EditHouseDetailsToDatabase(OrderFull order)
        {
            repo.UpdateHouseDetails(order);
            return RedirectToAction("EditMenu", new { id = order.HouseID });
        }      
        public IActionResult EditLotNum(int id)
        {
            var order = repo.GetOrderFull(id);
            return View(order);
        }
        public IActionResult EditLotNumToDatabase(OrderFull order)
        {
            repo.UpdateLotNum(order);
            return RedirectToAction("EditMenu", new { id = order.HouseID });
        }
        public IActionResult EditMenu(int id)
        {
            var order = repo.GetOrderFull(id);
            return View(order);
        }
        public IActionResult FullOrder(int id)
        {
            var order = repo.FullOrder(id);                      
            ViewBag.BuilderName = repo.PickBuilder((int)order.BuilderID);
            ViewBag.BalusterType = repo.PickBaluster((int)order.BalStyleID);
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
        public IActionResult MillWork(int id)
        {
            ViewBag.Balusters = repo.GetBalusterStyle();
            var order = repo.GetOrderFull(id);           
            return View(order);
        }
        public IActionResult MillWorkToDatebase(OrderFull order)
        {
            repo.UpdateMillWork(order);
            return RedirectToAction("EditMenu", new { id = order.HouseID });
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
