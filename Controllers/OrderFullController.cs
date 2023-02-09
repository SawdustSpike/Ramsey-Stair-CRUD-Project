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
            order.CapTypes = repo.PickCapType();
            order.RailTypes = repo.PickRailType();
            order.RailStyles = repo.PickRailStyle();
            order.Railines = repo.GetAllRail(id);
            order.Mantles = repo.GetMantles(id);
            order.TubFronts = repo.GetTubFronts(id);
            order.WallAccesses = repo.GetWallAccesses(id);
            order.Niches = repo.GetNiches(id);

            return View(order);
        }
            public ActionResult Index(string sortOrder)
            {
                
                ViewBag.LotNumSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                ViewBag.MeasureDateSortParm = sortOrder == "MDate" ? "Mdate_desc" : "MDate";
            ViewBag.InvoiceNumberSortParm = sortOrder == "INum" ? "INum_desc" : "INum";
            ViewBag.InstallDateSortParm = sortOrder == "IDate" ? "Idate_desc" : "IDate";
            ViewBag.InvoiceDateSortParm = sortOrder == "VDate" ? "Vdate_desc" : "VDate";
            var order = repo.GetAllOrderFull();
                switch (sortOrder)
                {
                case "name_desc":
                        order = order.OrderByDescending(s => s.LotNum);
                        break;
                case "MDate":
                        order = order.OrderBy(s => s.MeasureDate);
                        break;
                case "Mdate_desc":
                        order = order.OrderByDescending(s => s.MeasureDate);
                        break;
                case "INum":
                    order = order.OrderBy(s => s.InvoiceNum);
                    break;
                case "INum_desc":
                    order = order.OrderByDescending(s => s.InvoiceNum);
                    break;
                case "VDate":
                    order = order.OrderBy(s => s.InvoiceDate);
                    break;
                case "Vdate_desc":
                    order = order.OrderByDescending(s => s.InvoiceDate);
                    break;
                case "IDate":
                    order = order.OrderBy(s => s.InstallDate);
                    break;
                case "Idate_desc":
                    order = order.OrderByDescending(s => s.InstallDate);
                    break;

                default:
                        order = order.OrderBy(s => s.LotNum);
                        break;
                }
                return View(order.ToList());
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

    }
}
