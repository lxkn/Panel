using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Panel.Models;

namespace Panel.Models
{
 public class PizzaContext : DbContext
 {
  public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
  {
  }

  public DbSet<Dish> Dishes { get; set; }
  public DbSet<Order> Orders { get; set; }
 }
}
