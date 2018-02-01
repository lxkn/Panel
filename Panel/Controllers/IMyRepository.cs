using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panel.Models;

namespace Panel.Controllers
{
 public interface IMyRepository
 {
  ICollection<Order> GetAllOrders();
 }
}
