using Microsoft.AspNetCore.Mvc;

namespace MedicalClinic.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult GetAllUsers()
        {
            return View();
        }
    }
}
