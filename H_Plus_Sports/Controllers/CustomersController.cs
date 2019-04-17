﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H_Plus_Sports.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H_Plus_Sports.Controllers
{
    [Produces("application/json")]
    [Route("api/Customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly H_Plus_SportsContext _context;
        public CustomersController(H_Plus_SportsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            return Ok();
        }

        [HttpGet("{id}", Name = "GetCustomer")]
        public IActionResult GetCustomer([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostCustomer([FromBody] object obj)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutCustomer([FromRoute] int id, [FromBody] object obj)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer([FromRoute] int id)
        {
            return Ok();
        }
    }
}