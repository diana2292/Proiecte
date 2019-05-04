using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Models
{
  public class ProductsWebContext  :  DbContext

  {
    public ProductsWebContext(DbContextOptions<ProductsWebContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

  }
}
