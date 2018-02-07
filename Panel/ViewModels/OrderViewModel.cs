using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel.ViewModels
{
 public class OrderViewModel
 {
  [Key]
  public int OrderId { get; set; }
  public string Address { get; set; }
  public int Phone { get; set; }
  public string TimeStart { get; set; }
  public string TimeStop { get; set; }
  public int Status { get; set; } // 0 - UNCONFIRMED 1- IN REALISATION 2- MADE
  public ICollection<DishViewModel> orderList { get; set; }

 }
}
