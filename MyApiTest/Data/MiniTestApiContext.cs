using Microsoft.EntityFrameworkCore;
using MyApiTest.Model;

namespace MyApiTest.Data
{
    public class MiniTestApiContext: DbContext
    {
        public MiniTestApiContext(DbContextOptions<MiniTestApiContext> opt):base(opt) {    
        }
        public DbSet<Book> books { get; set; }
    }
}
