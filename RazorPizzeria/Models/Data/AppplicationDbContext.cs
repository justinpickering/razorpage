using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;


namespace RazorPizzeria.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        //makes a table in our database
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        { 
        
        }
    }
}
