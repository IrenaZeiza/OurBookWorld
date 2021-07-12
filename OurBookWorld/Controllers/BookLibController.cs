using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OurBookWorld.UI.Controllers
{
    public class BookLibController : Controller
    {
        // GET: /<controller>/
       


        public IActionResult Classics()
        {
            return View();
        }

        public IActionResult Bestsellers()
        {
            return View();
        }

        public IActionResult Science()
        {
            return View();
        }

        public IActionResult Return()
        {
            return View();
        }



        //send here list of the books
    }
}
