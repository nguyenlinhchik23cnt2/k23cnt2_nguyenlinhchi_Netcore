using Microsoft.AspNetCore.Mvc;

namespace nlcleson02.Controllers
{
    public class NlcproductController : Controller
    {
        public IActionResult NlcIndex()
        {
            ViewData["MessageData"] = "du lieu tu viewdata";
            ViewBag.messageData = "du lieu tu viewbag";
            TempData["messageData"] = "du lieu tu tempdata";
            return View();
        }
    }
}
