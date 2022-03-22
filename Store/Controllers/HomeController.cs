using Microsoft.AspNetCore.Mvc;
using Store.Data;
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

        ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,
                              IConfiguration configuration,
                              IUserContext dataContext,
                              ApplicationDbContext context)
        {
            _logger = logger;
            _configuration = configuration;
            _dataContext = dataContext;
            _context = context;
           
        }


        public IActionResult Index()
        {

            //var s = _dataContext.GetAllUser();
            //var e = _dataContext.GetUserById(2);
            var users = _context.Users.ToList();

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