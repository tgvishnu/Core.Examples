using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H_Plus_Sports.Controllers
{
    [Produces("application/json")]
    [Route("api/Orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public OrdersController()
        {

        }

        [HttpGet]
        public IActionResult GetOrder()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostOrder([FromBody] object obj)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutOrder([FromRoute] int id, [FromBody] object obj)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder([FromRoute] int id)
        {
            return Ok();
        }
    }
}