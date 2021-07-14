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
            List<BookViewModel> BookList = new List<BookViewModel>();

            BookViewModel bookModel = new BookViewModel()
            {
                Id = "1.1",
                Name = " <<War and Peace>> ",
                Author = "Tolstoy, Lev",
                Type = "Classic"
            }; 
            BookViewModel bookModel1 = new BookViewModel()
            {
                Id = "1.2",
                Name = "<<Animal Farm>>",
                Author = "Orwell, George",
                Type = "Classic"
            }; 
            
            BookViewModel bookModel2 = new BookViewModel()
            {
                Id = "1.3",
                Name = "<<Gone with the Winds>>",
                Author = "Mitchell, Margaret",
                Type = "Classic"
            };


            BookViewModel bookModel3 = new BookViewModel()
            {
                Id = "1.4",
                Name = "<<The Great Gatsby>>",
                Author = "Fitzgerald, F.Scott",
                Type = "Classic"
            };

            BookList.Add(bookModel);
            BookList.Add(bookModel1);
            BookList.Add(bookModel2);
            BookList.Add(bookModel3);

            return View(BookList);



        }

        public IActionResult Bestsellers()
        {
            List<BookViewModel> BookList = new List<BookViewModel>();

            BookViewModel bookModel = new BookViewModel()
            {
                Id = "2.1",
                Name = " <<Harry Potter>> ",
                Author = "Rowling, Joanne",
                Type = "Bestseller"
            };
            BookViewModel bookModel1 = new BookViewModel()
            {
                Id = "2.2",
                Name = "<<Twilight>>",
                Author = "Meyer, Stephenie",
                Type = "Bestseller"
            };

            BookViewModel bookModel2 = new BookViewModel()
            {
                Id = "2.3",
                Name = "<<The Hunger Games>>",
                Author = "Mitchell, Margaret",
                Type = "Bestseller"
            };


            BookViewModel bookModel3 = new BookViewModel()
            {
                Id = "2.4",
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

            BookViewModel bookModel = new BookViewModel()
            {
                Id = "3.1",
                Name = " <<On the Generalized Theory of Gravitation>> ",
                Author = "Einstein, Albert",
                Type = "Science"
            };
            BookViewModel bookModel1 = new BookViewModel()
            {
                Id = "3.2",
                Name = "<<Research on Radioactive Substances>>",
                Author = "Curie, Marie",
          
                Type = "Science"
            };

            BookViewModel bookModel2 = new BookViewModel()
            {
                Id = "3.3",
                Name = "<<On the Origin of Species>>",
                Author = "Darwin, Charles",
                Type = "Science"
            };


            BookViewModel bookModel3 = new BookViewModel()
            {
                Id = "3.4",
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

        //List<BookViewModel> ClassicBook = new List<BookViewModel>
        //{
        //new BookViewModel() {Name = "Master and Margharita", Id = 1, Author = "Bulgakov"},
        //new BookViewModel() {Name = "Romeo & Julieta", Id = 2, Author = "Shakespeare"},
        //new BookViewModel() {Name = "War and Peace", Id = 3, Author = "Tolstoy"}
        //};

        //send here list of the books
    }
}
