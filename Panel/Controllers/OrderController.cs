using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Panel.Controllers;

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
  public string Get()
  {
   return "value";
  }

  // GET api/<controller>/5
  [HttpGet("{id}")]
  public string Get(int id)
  {
   return "value";
  }

  // POST api/<controller>
  [HttpPost]
  public void Post([FromBody]string value)
  {
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
