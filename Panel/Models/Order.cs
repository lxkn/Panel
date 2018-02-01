using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel.Models
{
 public class Order
 {
  [Key]
  public int OrderId { get; set; }
  public string Address { get; set; }
  public int Phone { get; set; }
  public string TimeStart { get; set; }
  public string TimeStop { get; set; }
  public string Status { get; set; }
  public ICollection<Dish> orderList { get; set; }
 }
}
