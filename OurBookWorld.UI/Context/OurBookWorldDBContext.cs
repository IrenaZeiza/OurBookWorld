
using OurBookWorld.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace OurBookWorld.UI.Context
{
    public class OurBookWorldDBContext : DbContext
    {
        public DbSet<UserContactsViewModel> Users

        {
            get; set;
        }
        public DbSet<BookViewModel> Books
        {
            get; set;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite($"Data Source= OurBookLibraryDatabase.db");


    }
}
