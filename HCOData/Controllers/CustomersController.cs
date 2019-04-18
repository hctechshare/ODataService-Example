using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HCOData.Models;
using Microsoft.AspNet.OData;

namespace HCOData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private fatherhennepincsaContext _db;

        public CustomersController(fatherhennepincsaContext context)
        {
            _db = context;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Customer);
        }

        [HttpGet()]
        [Route("{custId:int}")]
        public IActionResult Get(int custId)
        {
            return Ok(_db.Customer.Where(csa => csa.CustomerId == custId));
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Post([FromBody] Customer customer)
        {
            _db.Customer.Add(customer);
            await _db.SaveChangesAsync();
            return Created("Created customer", customer);
        }
    }
}
