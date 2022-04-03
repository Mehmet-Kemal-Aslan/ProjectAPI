using Microsoft.EntityFrameworkCore;

namespace ProjectAPI.Models
{
    public class BookApiContext: DbContext
    {
        public BookApiContext(DbContextOptions<BookApiContext> options)
            : base(options) { }
        public DbSet<BookApiModel> Books { get; set;}
    }
}
