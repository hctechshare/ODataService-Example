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
    public class OrdersController : ControllerBase
    {
        private fatherhennepincsaContext _db;

        public OrdersController (fatherhennepincsaContext context)
        {
            _db = context;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Csaorder);
        }

        [HttpGet()]
        [Route("{custId:int}")]
        public IActionResult Get(int custId)
        {
            return Ok(_db.Csaorder.Where(csa => csa.CustomerId == custId));
        }

        [HttpPost]
        public async Task<ActionResult<Csaorder>> Post([FromBody] Csaorder order)
        {
            _db.Csaorder.Add(order);
            await _db.SaveChangesAsync();
            return Created("Created Order", order);
        }

    }
}
