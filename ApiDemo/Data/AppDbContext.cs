using System.Data.Common;
using Microsoft.EntityFrameworkCore;    
using ApiDemo.Models;
using ApiDemo.Data;

namespace ApiDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveModel> Leaves { get; set; }     
    }
}
