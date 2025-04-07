using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Order1", "Order2","Order3","Order4","Order5","Order6" };
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        ///GET api/<OrdersController>/5
        [HttpGet("{id1}/{id2}")]
        [ActionName("GetCombinedOrder")]
        public string GetCombinedOrder(int id1, int id2)
        {
            return String.Concat("Order", id1.ToString()) + String.Concat(" Order", id2.ToString());
        }

        // POST api/<OrdersController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return "Order Posted";
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "Order Edited";
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Order Deleted";
        }
    }
}
