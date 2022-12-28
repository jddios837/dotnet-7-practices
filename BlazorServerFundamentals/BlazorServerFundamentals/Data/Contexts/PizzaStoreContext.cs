using Microsoft.EntityFrameworkCore;

namespace BlazorServerFundamentals.Data.Contexts;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<PizzaSpecial> Specials { get; set; }
}