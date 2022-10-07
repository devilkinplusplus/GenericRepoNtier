using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataAccess.Concrete
{
    public class BooksDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-0AVBIPRU9F2;Database=Books;Integrated Security =True");
        }

        public DbSet<Category> Categories{ get; set; }
        public DbSet<Book> Books{ get; set; }
    }
}