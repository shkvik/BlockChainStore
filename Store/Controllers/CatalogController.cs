using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View("IndexCatalog");
        }
    }
}
