using Microsoft.AspNetCore.Mvc;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Service;

namespace Ramsey_Stair_CRUD_Project.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(User user)
        {
            SecurityService ser = new SecurityService();
            if (ser.IsValid(user))
            {
                return View("LoginSuccess", user);
            }
            else
            {
                return View("LoginFail", user);
            }
            
        }

    }
}
