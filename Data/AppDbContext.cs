using ProjectOrangeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectOrangeApi.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }

  public DbSet<Product> Products => Set<Product>();
  public DbSet<Category> Categories => Set<Category>();
  public DbSet<Order> Orders => Set<Order>();
  public DbSet<OrderItem> OrderItems => Set<OrderItem>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Category>().HasData(
      new Category { Id = 1, Name = "Phones" },
      new Category { Id = 2, Name = "Laptops" },
      new Category { Id = 3, Name = "Accessories" }
    );

    modelBuilder.Entity<Product>().HasData(
      new Product
      {
        Id = 1,
        Name = "iPhone 15",
        Description = "Apple smartphone",
        Price = 59999,
        StockQuantity = 10,
        ImageUrl = "",
        CategoryId = 1
      },
      new Product
      {
        Id = 2,
        Name = "Mechanical Keyboard",
        Description = "RGB keyboard",
        Price = 3500,
        StockQuantity = 25,
        ImageUrl = "",
        CategoryId = 3
      }
    );
  }
}