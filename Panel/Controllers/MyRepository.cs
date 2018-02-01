using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panel.Models;

namespace Panel.Controllers
{
 public class MyRepository : IMyRepository
 {
  private PizzaContext _dbContext;

  public MyRepository(PizzaContext dbContext)
  {
   _dbContext = dbContext;
  }
  public ICollection<Order> GetAllOrders()
  {
   return _dbContext.Orders.ToList();
  }
 }
}
