using Microsoft.AspNetCore.Mvc;
using NlcLab06.Models;

namespace NlcLab06.Controllers
{
    public class NlcEmployeeController : Controller
    {
        private static List<NlcEmployee> nlcListEmployee = new List<NlcEmployee>
        {
           new NlcEmployee
                {
                    NlcId = 1,
                    NlcName = "Nguyễn Linh Chi", // Sinh viên
                    NlcBirthDay = new DateTime(2005, 01, 24),
                    NlcEmail = "nguyenlinhchi022@gmail.com",
                    NlcPhone = "0366084921",
                    NlcSalary = 0,
                    NlcStatus = "sinh viên"
                },

            new NlcEmployee
            {
                NlcId = 2,
                NlcName = "Trần Văn An",
                NlcBirthDay = new DateTime(1993, 5, 20),
                NlcEmail = "an.tran@example.com",
                NlcPhone = "0901234567",
                NlcSalary = 15000000,
                NlcStatus = "Đang làm"
            },
            new NlcEmployee
            {
                NlcId = 3,
                NlcName = "Lê Thị Hoa",
                NlcBirthDay = new DateTime(1995, 11, 8),
                NlcEmail = "hoa.le@example.com",
                NlcPhone = "0987654321",
                NlcSalary = 12000000,
                NlcStatus = "Nghỉ việc"
            },
            new NlcEmployee
            {
                NlcId = 4,
                NlcName = "Phạm Minh Tuấn",
                NlcBirthDay = new DateTime(1989, 3, 2),
                NlcEmail = "tuan.pham@example.com",
                NlcPhone = "0934567890",
                NlcSalary = 20000000,
                NlcStatus = "Đang làm"
            },
            new NlcEmployee
            {
                NlcId = 5,
                NlcName = "Đỗ Thị Hạnh",
                NlcBirthDay = new DateTime(1997, 7, 12),
                NlcEmail = "hanh.do@example.com",
                NlcPhone = "0978123456",
                NlcSalary = 13000000,
                NlcStatus = "Đang làm"
            }
        };


        public IActionResult NlcIndex()
        {
            return View(nlcListEmployee);
        }

        
        public IActionResult NlcCreate()
        {
            return View(); // Mặc định sẽ gọi đến Views/NlcEmployee/NlcCreate.cshtml
        }
        [HttpPost]
        public IActionResult NlcCreateSubmit(NlcEmployee newEmp)
        {
            if (ModelState.IsValid)
            {
                // Tự động tăng ID
                newEmp.NlcId = nlcListEmployee.Max(e => e.NlcId) + 1;

                // Thêm vào danh sách
                nlcListEmployee.Add(newEmp);

                // Chuyển hướng về trang danh sách
                return RedirectToAction("NlcIndex");
            }

            // Nếu model không hợp lệ, trả về form thêm mới
            return View("NlcCreate", newEmp);
        }

        // GET: Hiển thị form sửa nhân viên theo id
        [HttpGet]
        public IActionResult NlcEdit(int id)
        {
            var emp = nlcListEmployee.FirstOrDefault(e => e.NlcId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        // POST: Cập nhật thông tin nhân viên
        [HttpPost]
        public IActionResult NlcEditPUT(NlcEmployee updatedEmp)
        {
            if (!ModelState.IsValid)
            {
                return View("NlcEdit", updatedEmp);
            }

            var emp = nlcListEmployee.FirstOrDefault(e => e.NlcId == updatedEmp.NlcId);
            if (emp == null)
            {
                return NotFound();
            }

            // Cập nhật các trường thông tin
            emp.NlcName = updatedEmp.NlcName;
            emp.NlcBirthDay = updatedEmp.NlcBirthDay;
            emp.NlcEmail = updatedEmp.NlcEmail;
            emp.NlcPhone = updatedEmp.NlcPhone;
            emp.NlcSalary = updatedEmp.NlcSalary;
            emp.NlcStatus = updatedEmp.NlcStatus;

            return RedirectToAction("NlcIndex");
        }
        // GET: Xóa nhân viên theo id
        public IActionResult NlcDelete(int id)
        {
            var emp = nlcListEmployee.FirstOrDefault(e => e.NlcId == id);
            if (emp == null)
            {
                return NotFound();
            }

            nlcListEmployee.Remove(emp);

            return RedirectToAction("NlcIndex");
        }

    }
}
