using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Product1", "Product2", "Product3", "Product4", "Product5", "Product6" };
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Product1";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return "Product saved...";
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "Product updated";
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Product Deleted";
        }
    }
}
