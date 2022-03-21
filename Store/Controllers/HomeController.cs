using Microsoft.AspNetCore.Mvc;
using Store.Models;
using Store.Services;
using System.Diagnostics;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IUserContext _dataContext;

        public HomeController(ILogger<HomeController> logger,
                              IConfiguration configuration,
                              IUserContext dataContext)
        {
            _logger = logger;
            _configuration = configuration;
            _dataContext = dataContext;
           
        }


        public IActionResult Index()
        {

            var s = _dataContext.GetAllUser();
            var e = _dataContext.GetUserById(2);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}