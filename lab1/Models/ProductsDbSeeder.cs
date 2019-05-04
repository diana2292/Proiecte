using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Models
{
  public class ProductsDbSeeder
  {

    public static void Initialize(ProductsWebContext context)
    {
      context.Database.EnsureCreated();

      
      if (context.Products.Any())
      {
        return;   
      }

      context.Products.AddRange(
          new Product
          {
            Name = "Rose",
            Description = "White, Yellow, Blue, Red",
            Cathegory = "Lenjerie",
            Price = 120
          },
          new Product
          {
            Name = "Intimissimi",
            Description = "Yellow, Red",
            Cathegory = "Lenjerie",
            Price = 350
          },
          new Product
          {
            Name ="Vanilla",
            Description="Red, White, Blue, Black, Pink",
            Cathegory = "Lenjerie",
            Price = 230
          }
      );
      context.SaveChanges();
    }
  }
}

