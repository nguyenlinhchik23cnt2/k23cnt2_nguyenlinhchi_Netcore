using Microsoft.AspNetCore.Mvc;
using Nlclesson05.Models.DataModels;

namespace Nlclesson05.Controllers
{
    public class NlcMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NlcGetMember()
        {
            var nlcMember = new NlcMember
            {
                NlcMemberId = Guid.NewGuid().ToString(),
                NlcMemberName = "Linh Chi",
                NlcMemberfullName = "Nguyen Linh Chi",
                NlcPassword = "1234567@",
                NlcEmail = "linhchi@example.com"
            };

            ViewBag.nlcMember = nlcMember;
            return View();
        }
    }
}
