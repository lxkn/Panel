using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Panel.Models;
using Panel.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Panel
{
 [Route("api/orders")]
 public class OrderController : Controller
 {
  private IMyRepository _repository;

  public OrderController(IMyRepository repository)
  {
   _repository = repository;
  }
  // GET: api/<controller>
  [HttpGet]
  public IActionResult Get()
  {
   try
   {
    var results = _repository.GetAllOrders();
    return Ok(Mapper.Map<IEnumerable<OrderViewModel>>(results));
   }
   catch (Exception e)
   {
    return BadRequest("Something went wrong..");
   }
  }

  // GET api/<controller>/5
  [HttpGet("{id}")]
  public string Get(int id)
  {
   return "value";
  }

  // POST api/<controller>
  [HttpPost]
  public IActionResult Post([FromBody]OrderViewModel order)
  {
   try
   {
    if (ModelState.IsValid)
    {
     var newOrder = Mapper.Map<Order>(order);
     _repository.AddOrder(newOrder);
     return Created($"api/players/{order.Address}", Mapper.Map<OrderViewModel>(newOrder));
    }
   }
   catch(Exception e)
   {
   }
   return BadRequest("Something went wrong..., failed to add order!");
  }

  // PUT api/<controller>/5
  [HttpPut("{id}")]
  public void Put(int id, [FromBody]string value)
  {
  }

  // DELETE api/<controller>/5
  [HttpDelete("{id}")]
  public void Delete(int id)
  {
  }
 }
}
