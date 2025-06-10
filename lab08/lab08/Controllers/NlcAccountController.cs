using lab08.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace lab08.Controllers
{
    
    public class NlcAccountController : Controller
    {
        private static List<NlcAccount> nlcListAccount = new List<NlcAccount>
{
    new NlcAccount
    {
        NlcId = 1,
        NlcFullName = "Nguyễn Linh Chi",
        NlcEmail = "nguyenlinhchi022@gmail.com",
        NlcPhone = "0366084921",
        NlcAddress = "12 lí ải, song phương, hoài đức, hà nội",
        NlcAvatar = "avatar1.jpg",
        NlcBirthday = new DateTime(2005, 1, 24),
        NlcGender = "Nam",
        NlcPassword = "An123456",
        NlcFacebook = "https://facebook.com/nguyenvanan"
    },
    new NlcAccount
    {
        NlcId = 2,
        NlcFullName = "Trần Thị Bích",
        NlcEmail = "bich.tran@example.com",
        NlcPhone = "091-987-6543",
        NlcAddress = "456 Nguyễn Trãi, TP.HCM",
        NlcAvatar = "avatar2.png",
        NlcBirthday = new DateTime(1993, 8, 21),
        NlcGender = "Nữ",
        NlcPassword = "Bich123456",
        NlcFacebook = "https://facebook.com/tranthibich"
    },
    new NlcAccount
    {
        NlcId = 3,
        NlcFullName = "Phạm Quốc Hùng",
        NlcEmail = "hung.pham@example.com",
        NlcPhone = "092-333-4444",
        NlcAddress = "789 Phan Đình Phùng, Huế",
        NlcAvatar = "avatar3.jpg",
        NlcBirthday = new DateTime(1990, 12, 5),
        NlcGender = "Nam",
        NlcPassword = "Hung123456",
        NlcFacebook = "https://facebook.com/phamquochung"
    },
    new NlcAccount
    {
        NlcId = 4,
        NlcFullName = "Lê Minh Châu",
        NlcEmail = "chau.le@example.com",
        NlcPhone = "093-888-9999",
        NlcAddress = "12 Hai Bà Trưng, Đà Nẵng",
        NlcAvatar = "avatar4.png",
        NlcBirthday = new DateTime(1998, 2, 10),
        NlcGender = "Nữ",
        NlcPassword = "Chau123456",
        NlcFacebook = "https://facebook.com/leminhchau"
    },
    new NlcAccount
    {
        NlcId = 5,
        NlcFullName = "Đỗ Thanh Tùng",
        NlcEmail = "tung.do@example.com",
        NlcPhone = "094-222-3333",
        NlcAddress = "68 Trần Hưng Đạo, Cần Thơ",
        NlcAvatar = "avatar5.jpg",
        NlcBirthday = new DateTime(1992, 7, 30),
        NlcGender = "Nam",
        NlcPassword = "Tung123456",
        NlcFacebook = "https://facebook.com/dothanhtung"
    }
        };


        public ActionResult NlcIndex()
        {
            return View(nlcListAccount);
        }

        // GET: NlcAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NlcAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NlcAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        
        public ActionResult Create(NlcAccount model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // Trả lại view kèm lỗi nếu validation fail
            }

            model.NlcId = nlcListAccount.Count + 1;
            nlcListAccount.Add(model);

            return RedirectToAction(nameof(NlcIndex));
        }

      
        // GET: NlcAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            var acc = nlcListAccount.FirstOrDefault(x => x.NlcId == id);
            if (acc == null)
            {
                return NotFound();
            }
            return View(acc); // truyền dữ liệu vào view để hiển thị form sửa
        }

        // POST: NlcAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            var acc = nlcListAccount.FirstOrDefault(x => x.NlcId == id);
            if (acc == null)
            {
                return NotFound();
            }

            try
            {
                // Cập nhật thông tin từ form
                acc.NlcFullName = collection["NlcFullName"];
                acc.NlcEmail = collection["NlcEmail"];
                acc.NlcPhone = collection["NlcPhone"];
                acc.NlcAddress = collection["NlcAddress"];
                acc.NlcAvatar = collection["NlcAvatar"];
                acc.NlcBirthday = DateTime.Parse(collection["NlcBirthday"]);
                acc.NlcGender = collection["NlcGender"];
                acc.NlcPassword = collection["NlcPassword"];
                acc.NlcFacebook = collection["NlcFacebook"];

                return RedirectToAction(nameof(NlcIndex)); // hoặc Index nếu tên đúng là vậy
            }
            catch
            {
                return View(acc);
            }
        }

        // GET: NlcAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NlcAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
