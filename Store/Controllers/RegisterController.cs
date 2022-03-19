using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("IndexRegister");
        }
    }
}
