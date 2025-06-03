using Microsoft.AspNetCore.Mvc;
using Nlclab07.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nlclab07.Controllers
{
    public class NlcEmployeeController : Controller
    {
        // Mock data
        private static List<NlcEmployee> nlcListEmployee = new List<NlcEmployee>
        {
            new NlcEmployee
            {
                NlcId = 23001122,
                NlcName = "Nguyen Linh Chi",
                NlcBirthDay = new DateTime(2005, 1, 24),
                NlcEmail = "linhchi@gmail.com",
                NlcPhone = "0366084921",
                NlcSalary = 12000000m,
                NlcStatus = true
            },
            new NlcEmployee
            {
                NlcId = 2,
                NlcName = "Tran Thi B",
                NlcBirthDay = new DateTime(1992, 8, 15),
                NlcEmail = "tranthib@example.com",
                NlcPhone = "0912345678",
                NlcSalary = 13500000m,
                NlcStatus = true
            }
        };

        // GET: NlcEmployee
        public IActionResult NlcIndex()
        {
            return View(nlcListEmployee);
        }

        // GET: Details
        public IActionResult NlcDetails(int id)
        {
            var nlcEmployee = nlcListEmployee.FirstOrDefault(x => x.NlcId == id); // line 46?
            if (nlcEmployee == null)
            {
                return NotFound();
            }

            return View(nlcEmployee);
        }





        // GET: Create
        public IActionResult NlcCreate()
        {
            var nlcEmplyoee = new NlcEmployee();
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NlcCreate(NlcEmployee nlcModel)
        {
            try
            {
                // Thêm mới nhân viên vào list
                nlcModel.NlcId = nlcListEmployee.Max(x => x.NlcId) + 1;
                nlcListEmployee.Add(nlcModel);
                return RedirectToAction(nameof(NlcIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: Edit
        // GET: NlcEmployee/NlcEdit/5
        public ActionResult NlcEdit(int id)
        {
            var nlcEmployee = nlcListEmployee.FirstOrDefault(x => x.NlcId == id);
            if (nlcEmployee == null)
            {
                return NotFound();
            }
            return View(nlcEmployee);
        }

        // POST: NlcEmployee/NlcEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NlcEdit(int id, NlcEmployee nlcModel)
        {
            try
            {
                for (int i = 0; i < nlcListEmployee.Count(); i++)
                {
                    if (nlcListEmployee[i].NlcId == id)
                    {
                        nlcListEmployee[i] = nlcModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(NlcIndex));
            }
            catch
            {
                return View(nlcModel); // giữ lại dữ liệu nếu có lỗi
            }
        }

       

        // GET: Delete
        public IActionResult Delete(int id)
        {
            var emp = nlcListEmployee.FirstOrDefault(e => e.NlcId == id);
            return emp == null ? NotFound() : View(emp);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var emp = nlcListEmployee.FirstOrDefault(e => e.NlcId == id);
                if (emp != null)
                {
                    nlcListEmployee.Remove(emp);
                }

                return RedirectToAction(nameof(NlcIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
