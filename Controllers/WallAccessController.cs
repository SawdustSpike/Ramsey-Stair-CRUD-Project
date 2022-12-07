using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class WallAccessController : Controller
    {
        private readonly IWallAccessRepository repo;
        public WallAccessController(IWallAccessRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index(int id)
        {
            var WallAccess = repo.GetAllWallAccesss(id);
            var order = repo.GetLotNum(id);
            ViewBag.LotNum = order.LotNum;
            ViewBag.HouseID = order.HouseID;
            return View(WallAccess);
        }
        public IActionResult InsertWallAccess(int id)
        {
            ViewBag.HouseID = id;
            return View(new WallAccess());
        }
        public IActionResult InsertWallAccessToDatabase(WallAccess wallAccess)
        {
            repo.InsertWallAccess(wallAccess);
            return RedirectToAction("Index", new { id = wallAccess.HouseID });
        }
    }
}
    