using Microsoft.EntityFrameworkCore;

namespace AsyncHello.Entities
{
    public class CustomerContext : DbContext
    {
        
        public CustomerContext(DbContextOptions<CustomerContext> options)
           : base(options)
        {
        }

         public DbSet<Customer> Customers { get; set; }
    }
    
}