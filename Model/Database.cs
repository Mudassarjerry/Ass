using Microsoft.EntityFrameworkCore;

namespace Cerebral_Palsy.Model
{
    public class Database : DbContext
    
    {

        public CustomerDB_Context(DbContextOptions<CustomerDB_Context> options) : base(options)
        {
        }

        public DbSet<Customer> customer { get; set; }
        public DbSet<Product> products { get; set; }
    {
    }
}
