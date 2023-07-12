using Microsoft.EntityFrameworkCore;
using ConfigurationUI.Models;
namespace ConfigurationUI.DataBase
{
public class context : DbContext
{
    public context(DbContextOptions<context> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    }
}
