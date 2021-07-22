using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OurBookWorld.UI.Context;
using OurBookWorld.UI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OurBookWorld.UI.Controllers
{
    public class BookLibController : Controller
    {
        // GET: /<controller>/



        public IActionResult Classics()
        {
            var book = new BookViewModel();

            book.Author = "Tolstoy, Leo";
            book.Name = "<<War And Peace>>";
            book.Type = "Classic";

            using (var context = new OurBookWorldDBContext())
            {
                context.Add(book);
                context.SaveChanges();
                var books = context.Books.ToList();
            }

            List<BookViewModel> BookList = new List<BookViewModel>();

            BookViewModel bookModel = new BookViewModel()
            {
                Id = 11,
                Name = " <<War and Peace>> ",
                Author = "Tolstoy, Lev",
                Type = "Classic"
            };
            BookViewModel bookModel1 = new BookViewModel()
            {
                Id = 12,
                Name = "<<Animal Farm>>",
                Author = "Orwell, George",
                Type = "Classic"
            };

            BookViewModel bookModel2 = new BookViewModel()
            {
                Id = 13,
                Name = "<<Gone with the Winds>>",
                Author = "Mitchell, Margaret",
                Type = "Classic"
            };


            BookViewModel bookModel3 = new BookViewModel()
            {
                Id = 14,
                Name = "<<The Great Gatsby>>",
                Author = "Fitzgerald, F.Scott",
                Type = "Classic"
            };

            BookViewModel bookModel4 = new BookViewModel()
            {
                Id = 15,
                Name = "<<The Adventures of Tom Sawyer >>",
                Author = "Twain, Mark",
                Type = "Classic"
            };
            BookList.Add(bookModel);
            BookList.Add(bookModel1);
            BookList.Add(bookModel2);
            BookList.Add(bookModel3);
            BookList.Add(bookModel4);

            return View(BookList);



        }

        public IActionResult Bestsellers()
        {
            var book = new BookViewModel();

            book.Author = "Rowling, Joanne";
            book.Name = "<<Harry Potter>>";
            book.Type = "Bestseller";

            using (var context = new OurBookWorldDBContext())
            {
                context.Add(book);
                context.SaveChanges();
                var books = context.Books.ToList();
            }
            List<BookViewModel> BookList = new List<BookViewModel>();

            BookViewModel bookModel = new BookViewModel()
            {
                Id = 21,
                Name = " <<Harry Potter>> ",
                Author = "Rowling, Joanne",
                Type = "Bestseller"
            };
            BookViewModel bookModel1 = new BookViewModel()
            {
                Id = 22,
                Name = "<<Twilight>>",
                Author = "Meyer, Stephenie",
                Type = "Bestseller"
            };

            BookViewModel bookModel2 = new BookViewModel()
            {
                Id = 23,
                Name = "<<The Hunger Games>>",
                Author = "Mitchell, Margaret",
                Type = "Bestseller"
            };


            BookViewModel bookModel3 = new BookViewModel()
            {
                Id = 24,
                Name = "<<The Lord of the Rings>>",
                Author = "Tolkien, J. R. R.",
                Type = "Bestseller"
            };

            BookList.Add(bookModel);
            BookList.Add(bookModel1);
            BookList.Add(bookModel2);
            BookList.Add(bookModel3);

            return View(BookList);



        }

        public IActionResult Science()
        {
            List<BookViewModel> BookList = new List<BookViewModel>();

            var book = new BookViewModel();

            book.Author = "Einstein, Albert";
            book.Name = "<<On the Generalized Theory of Gravitation>>";
            book.Type = "Science";

            using (var context = new OurBookWorldDBContext())
            {
                context.Add(book);
                context.SaveChanges();
                var books = context.Books.ToList();
            }

            BookViewModel bookModel = new BookViewModel()
            {
                Id = 31,
                Name = " <<On the Generalized Theory of Gravitation>> ",
                Author = "Einstein, Albert",
                Type = "Science"
            };
            BookViewModel bookModel1 = new BookViewModel()
            {
                Id = 32,
                Name = "<<Research on Radioactive Substances>>",
                Author = "Curie, Marie",

                Type = "Science"
            };

            BookViewModel bookModel2 = new BookViewModel()
            {
                Id = 33,
                Name = "<<On the Origin of Species>>",
                Author = "Darwin, Charles",
                Type = "Science"
            };


            BookViewModel bookModel3 = new BookViewModel()
            {
                Id = 34,
                Name = "<<Atlas of Human Anatomy>>",
                Author = "Sinelnikov,R.D.",
                Type = "Science"
            };

            BookList.Add(bookModel);
            BookList.Add(bookModel1);
            BookList.Add(bookModel2);
            BookList.Add(bookModel3);

            return View(BookList);



        }


        public IActionResult Return()
        {
            return View();
        }

    


        public IActionResult Index()
        {
            var book = new BookViewModel();

            book.Author = "Tolstoy, Leo";
            book.Name = "<<War And Peace>>";
            book.Type = "Classic";

            using (var context = new OurBookWorldDBContext())
            {
                context.Add(book);
                context.SaveChanges();
                var books = context.Books.ToList();
            }

            return View();
        }

        

    }
}


