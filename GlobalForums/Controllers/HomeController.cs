using GlobalForums.Domains.Models.ErrorViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GlobalForums.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public override bool Equals(object? obj)
        {
            return obj is HomeController controller &&
                   EqualityComparer<ILogger<HomeController>>.Default.Equals(_logger, controller._logger);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}