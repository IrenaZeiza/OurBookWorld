using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OurBookWorld.UI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OurBookWorld.UI.Controllers
{
    public class BookLibController : Controller
    {
        // GET: /<controller>/
       


        public IActionResult Classics()
        {
            BookViewModel bookModel = new BookViewModel()
            {
                Id = 1,
                Name = "War and Peace",
                Author = "Tolstoy",
                Type = "Classic"
            };

            return View(bookModel);

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

        List<BookViewModel> ClassicBook = new List<BookViewModel>
        {
        new BookViewModel() {Name = "Master and Margharita", Id = 1, Author = "Bulgakov"},
        new BookViewModel() {Name = "Romeo & Julieta", Id = 2, Author = "Shakespeare"},
        new BookViewModel() {Name = "War and Peace", Id = 3, Author = "Tolstoy"}
        };

        //send here list of the books
    }
}
