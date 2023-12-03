using eCommerceBot.Domains.Entities;
using eCommerceBot.Settings;
using Microsoft.EntityFrameworkCore;

namespace eCommerceBot.Infrastructure;

public class AppDataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(AppSetting.NpgSqlConnection);
        base.OnConfiguring(optionsBuilder);
    }
}