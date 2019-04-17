using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H_Plus_Sports.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostProduct([FromBody] object obj)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutProduct([FromRoute] int id, [FromBody] object obj)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            return Ok();
        }
    }
}