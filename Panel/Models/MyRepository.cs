using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panel.Models;

namespace Panel.Models
{
 public class MyRepository : IMyRepository
 {
  private PizzaContext _dbContext;

  public MyRepository(PizzaContext dbContext)
  {
   _dbContext = dbContext;
  }

  public void AddOrder(Order order)
  {
   _dbContext.Orders.Add(order);
   _dbContext.SaveChanges();
  }

  public IEnumerable<Order> GetAllOrders()
  {
   return _dbContext.Orders.ToList();
  }
 }
}
