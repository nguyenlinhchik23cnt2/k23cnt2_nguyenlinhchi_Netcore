using lab08.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab08.Controllers
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

        public IActionResult NlcAbout()
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
