using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panel.Models;

namespace Panel.Models
{
 public interface IMyRepository
 {
  IEnumerable<Order> GetAllOrders();
  void AddOrder(Order order);
 }
}
