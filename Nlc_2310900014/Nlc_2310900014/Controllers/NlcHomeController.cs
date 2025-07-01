using Microsoft.AspNetCore.Mvc;
using Nlc_2310900014.Models;
using System.Diagnostics;

namespace Nlc_2310900014.Controllers
{
    public class NlcHomeController : Controller
    {
        private readonly ILogger<NlcHomeController> _logger;

        public NlcHomeController(ILogger<NlcHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NlcIndex()
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
    }
}
