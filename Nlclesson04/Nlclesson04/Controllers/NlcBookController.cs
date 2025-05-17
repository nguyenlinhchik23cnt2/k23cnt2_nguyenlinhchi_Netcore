using Microsoft.AspNetCore.Mvc;
using Nlclesson04.Models;
using System.Collections.Generic;

namespace Nlclesson04.Controllers
{
    public class NlcBookController : Controller
    {
        private List<NlcBook> nlcBooks = new List<NlcBook>
        {
            new NlcBook
            {
                NlcId = "B001",
                NlcTitle = "sách 1",
                NlcDescription = "A beginner-friendly guide to learning C# quickly.",
                NlcImage = "/images/anh1.jfif",
                NlcPrice = 19.99f,
                NlcPage = 350
            },
            new NlcBook
            {
                NlcId = "B002",
                NlcTitle = "sách 2",
                NlcDescription = "Advanced techniques and best practices for ASP.NET Core.",
                NlcImage = "/images/anh4.jpeg",
                NlcPrice = 29.99f,
                NlcPage = 480
            },
            new NlcBook
            {
                NlcId = "B003",
                NlcTitle = "sách 3",
                NlcDescription = "Practical guide to using EF Core for data access.",
                NlcImage = "/images/anh5.jfif",
                NlcPrice = 24.5f,
                NlcPage = 410
            },
            new NlcBook
            {
                NlcId = "B004",
                NlcTitle = "sách 4",
                NlcDescription = "Build modern web apps using Blazor and WebAssembly.",
                NlcImage = "/images/anh6.jfif",
                NlcPrice = 21.0f,
                NlcPage = 300
            },
            new NlcBook
            {
                NlcId = "B005",
                NlcTitle = "sách 5",
                NlcDescription = "Writing readable and maintainable C# code.",
                NlcImage = "/images/anh7.jfif",
                NlcPrice = 27.75f,
                NlcPage = 370
            }
        };

        // GET: /NlcBook/NlcIndex
        public IActionResult NlcIndex()
        {

            // dua du lieu len view 

            return View(nlcBooks); // truyền danh sách vào view
        }
        // GET: /NlcBook/NlcCreate
        public IActionResult NlcCreate()
        {

            NlcBook nlcbook = new NlcBook();

            return View(nlcBooks); 
        }
        public IActionResult NlcCreateubmit()
        {



            return RedirectToAction("NlcIndex");
        }
        public IActionResult NlcEdit(string id)
        {

           

            return View();
        }
        //
        public IActionResult NlcEditsubmit(NlcBook updatedBook)
        {
            

            return RedirectToAction("NlcIndex");
        }
    }
}
