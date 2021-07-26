using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
         


            List<BookViewModel> BookList = new List<BookViewModel>();

            BookViewModel bookModel = new BookViewModel()
            {
                Id = 101,
                Name = " <<War and Peace>> ",
                Author = "Tolstoy, Lev",
                Type = "Classic"
            };
            BookViewModel bookModel1 = new BookViewModel()
            {
                Id = 102,
                Name = " <<The Master and Margarita>> ",
                Author = "Bulgakov, Mikhail",
                Type = "Classic"
            };
            BookViewModel bookModel2 = new BookViewModel()
            {
                Id = 103,
                Name = "<<Animal Farm>>",
                Author = "Orwell, George",
                Type = "Classic"
            };

            BookViewModel bookModel3 = new BookViewModel()
            {
                Id = 104,
                Name = "<<Gone with the Winds>>",
                Author = "Mitchell, Margaret",
                Type = "Classic"
            };


            BookViewModel bookModel4 = new BookViewModel()
            {
                Id = 105,
                Name = "<<The Great Gatsby>>",
                Author = "Fitzgerald, F.Scott",
                Type = "Classic"
            };

            BookViewModel bookModel5 = new BookViewModel()
            {
                Id = 106,
                Name = "<<The Adventures of Tom Sawyer >>",
                Author = "Twain, Mark",
                Type = "Classic"
            };

            BookViewModel bookModel6 = new BookViewModel()
            {
                Id = 107,
                Name = "<<Jonathan Livingston Seagull>>",
                Author = "Bach, Richard ",
                Type = "Classic"
            };
            BookViewModel bookModel7 = new BookViewModel()
            {
                Id = 108,
                Name = "<<The Divine Comedy>>",
                Author = "Alighieri, Dante",
                Type = "Classic"
            };
            BookViewModel bookModel8 = new BookViewModel()
            {
                Id = 109,
                Name = "<<Ronia, the Robber's Daughter>>",
                Author = "Lindgren, Astrid",
                Type = "Classic"
            };
            BookViewModel bookModel9 = new BookViewModel()
            {
                Id = 110,
                Name = "<<The Plague>>",
                Author = "Camus, Albert",
                Type = "Classic"
            };
            BookViewModel bookModel10 = new BookViewModel()
            {
                Id = 111,
                Name = "<< To Kill a Mockingbird>>",
                Author = "Lee, Harper",
                Type = "Classic"
            };

            BookViewModel bookModel11 = new BookViewModel()
            {
                Id = 112,
                Name = "<< One Hundred Years of Solitude>>",
                Author = "Márquez, Gabriel García",
                Type = "Classic"
            };
            BookViewModel bookModel12 = new BookViewModel()
            {
                Id = 113,
                Name = "<< Crime and Punishment >>",
                Author = "Dostoevsky, Fyodor",
                Type = "Classic"
            };
            BookViewModel bookModel13 = new BookViewModel()
            {
                Id = 114,
                Name = "<<The Lion, the Witch and the Wardrobe>>",
                Author = "Lewis, C.S. ",
                Type = "Classic"
            };

            BookViewModel bookModel14 = new BookViewModel()
            {
                Id = 115,
                Name = "<<One Flew Over the Cuckoo's Nest>>",
                Author = "Kesey, Ken",
                Type = "Classic"
            };

            BookList.Add(bookModel);
            BookList.Add(bookModel1);
            BookList.Add(bookModel2);
            BookList.Add(bookModel3);
            BookList.Add(bookModel4);
            BookList.Add(bookModel6);
            BookList.Add(bookModel7);
            BookList.Add(bookModel8);
            BookList.Add(bookModel9);
            BookList.Add(bookModel10);
            BookList.Add(bookModel11);
            BookList.Add(bookModel12);
            BookList.Add(bookModel13);
            BookList.Add(bookModel14);

            return View(BookList);


        }



        public IActionResult Bestsellers()
        {
            


            List<BookViewModel> BookList = new List<BookViewModel>();

            BookViewModel bookModel = new BookViewModel()
            {
                Id = 201,
                Name = " <<Harry Potter and the Philosopher's Stone>> ",
                Author = "Rowling, Joanne",
                Type = "Bestseller"
            };
            BookViewModel bookModel1 = new BookViewModel()
            {
                Id = 202,
                Name = "<<Twilight>>",
                Author = "Meyer, Stephenie",
                Type = "Bestseller"
            };

            BookViewModel bookModel2 = new BookViewModel()
            {
                Id = 203,
                Name = "<<The Hunger Games>>",
                Author = "Collins, Suzanne",
                Type = "Bestseller"
            };


            BookViewModel bookModel3 = new BookViewModel()
            {
                Id = 204,
                Name = "<<The Lord of the Rings>>",
                Author = "Tolkien, J. R. R.",
                Type = "Bestseller"
            };
            BookViewModel bookModel4 = new BookViewModel()
            {
                Id = 205,
                Name = "<<The Little Prince>>",
                Author = "Antoine de Saint-Exupéry",
                Type = "Bestseller"
            };
            BookViewModel bookModel5 = new BookViewModel()
            {
                Id = 206,
                Name = "<<The Hobbit>>",
                Author = "Tolkien, J. R. R.",
                Type = "Bestseller"
            };
            BookViewModel bookModel6 = new BookViewModel()
            {
                Id = 207,
                Name = "<<And Then There Were None>>",
                Author = "Christie, Agatha",
                Type = "Bestseller"
            };
            BookViewModel bookModel7 = new BookViewModel()
            {
                Id = 208,
                Name = "<<Da Vinci Code>>",
                Author = "Brown, Den",
                Type = "Bestseller"
            };
            BookViewModel bookModel8 = new BookViewModel()
            {
                Id = 209,
                Name = "<<The Alchemist>>",
                Author = "Coelho, Paulo",
                Type = "Bestseller"
            };
            BookViewModel bookModel9 = new BookViewModel()
            {
                Id = 210,
                Name = "<<The Name of the Rose>>",
                Author = "Eco, Umberto",
                Type = "Bestseller"
            };
            BookViewModel bookModel10 = new BookViewModel()
            {
                Id = 211,
                Name = "<<The Tale of Peter Rabbit>>",
                Author = "Potter, Beatrix ",
                Type = "Bestseller"
            };
            BookViewModel bookModel11 = new BookViewModel()
            {
                Id = 212,
                Name = "<<The Diary of Anne Frank>>",
                Author = "Frank, Anne ",
                Type = "Bestseller"
            };

            BookViewModel bookModel12 = new BookViewModel()
            {
                Id = 213,
                Name = "<<Who Moved My Cheese?>>",
                Author = "Johnson, Spencer ",
                Type = "Bestseller"
            };

            BookViewModel bookModel13 = new BookViewModel()
            {
                Id = 214,
                Name = "<<The 7 Habits of Highly Effective People>>",
                Author = "Covey, Stephen R. ",
                Type = "Bestseller"
            };

            BookViewModel bookModel14 = new BookViewModel()
            {
                Id = 215,
                Name = "<<All Quiet on the Western Front>>",
                Author = "Remarque,Erich Maria",
                Type = "Bestseller"
            };


            BookList.Add(bookModel);
            BookList.Add(bookModel1);
            BookList.Add(bookModel2);
            BookList.Add(bookModel3);
            BookList.Add(bookModel4);
            BookList.Add(bookModel6);
            BookList.Add(bookModel7);
            BookList.Add(bookModel8);
            BookList.Add(bookModel9);
            BookList.Add(bookModel10);
            BookList.Add(bookModel11);
            BookList.Add(bookModel12);
            BookList.Add(bookModel13);
            BookList.Add(bookModel14);

            return View(BookList);



        }

        public IActionResult Science()
        {
            List<BookViewModel> BookList = new List<BookViewModel>();

       

            BookViewModel bookModel = new BookViewModel()
            {
                Id = 301,
                Name = " <<On the Generalized Theory of Gravitation>> ",
                Author = "Einstein, Albert",
                Type = "Science"
            };
            BookViewModel bookModel1 = new BookViewModel()
            {
                Id = 302,
                Name = "<<Research on Radioactive Substances>>",
                Author = "Curie, Marie",

                Type = "Science"
            };

            BookViewModel bookModel2 = new BookViewModel()
            {
                Id = 303,
                Name = "<<On the Origin of Species>>",
                Author = "Darwin, Charles",
                Type = "Science"
            };


            BookViewModel bookModel3 = new BookViewModel()
            {
                Id = 304,
                Name = "<<Atlas of Human Anatomy>>",
                Author = "Sinelnikov,R.D.",
                Type = "Science"
            };

            BookViewModel bookModel4 = new BookViewModel()
            {
                Id = 305,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
            BookViewModel bookModel5 = new BookViewModel()
            {
                Id = 306,
                Name = "<<A Short History of Nearly Everything>>",
                Author = "Bryson, Bill",
                Type = "Science"
            };
            BookViewModel bookModel6 = new BookViewModel()
            {
                Id = 307,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
            BookViewModel bookModel7 = new BookViewModel()
            {
                Id = 308,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
            BookViewModel bookModel8 = new BookViewModel()
            {
                Id = 309,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
            BookViewModel bookModel9 = new BookViewModel()
            {
                Id = 310,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
            BookViewModel bookModel10 = new BookViewModel()
            {
                Id = 311,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
            BookViewModel bookModel11 = new BookViewModel()
            {
                Id = 312,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
            BookViewModel bookModel12 = new BookViewModel()
            {
                Id = 313,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
            BookViewModel bookModel13 = new BookViewModel()
            {
                Id = 314,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
            BookViewModel bookModel14 = new BookViewModel()
            {
                Id = 315,
                Name = "<<A Brief History of Time>>",
                Author = "Hawking, Stephen",
                Type = "Science"
            };
       
            
            
            BookList.Add(bookModel);
            BookList.Add(bookModel1);
            BookList.Add(bookModel2);
            BookList.Add(bookModel3);
            BookList.Add(bookModel4);
            BookList.Add(bookModel6);
            BookList.Add(bookModel7);
            BookList.Add(bookModel8);
            BookList.Add(bookModel9);
            BookList.Add(bookModel10);
            BookList.Add(bookModel11);
            BookList.Add(bookModel12);
            BookList.Add(bookModel13);
            BookList.Add(bookModel14);

            return View(BookList);



        }


        public IActionResult Return()
        {

           

        //    if (!string.IsNullOrEmpty(Model.ErrorMessage))
        //    {
        //        @Model.ErrorMessage


        //    }
        //    if (!string.IsNullOrEmpty(Model.SucessMessage))
        //    {

        //        @Model.SuccessMessage


        //}

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

        public List<BookViewModel> BookList { get; set; }
        public void Connect()
        {
            var book = new BookViewModel();

            string cs = "Data Source=" + Environment.CurrentDirectory + "\\.db";
            using (var connection = new SQLiteConnection(cs))
            {
                var listOfMovies = new List<BookViewModel>();
                var stm = "SELECT * from Books";
                var command = new SQLiteCommand(stm, connection);
               
        
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        using (var context = new OurBookWorldDBContext())
                        {
                            context.Add(book);
                            context.SaveChanges();
                            var books = context.Books.ToList();
                        }




                    }


                  

                




            }

        }
    }
}

















