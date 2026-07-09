using Microsoft.EntityFrameworkCore;
using Demo_Api.Models;

namespace Demo_Api.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students => Set<Student>();

       
    }
}
