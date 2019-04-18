using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HCOData.Models;
namespace HCOData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private fatherhennepincsaContext _db;

        public FeedbackController(fatherhennepincsaContext context)
        {
            _db = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Feedback);
        }

        [HttpGet()]
        [Route("{fbID:int}")]
        public IActionResult Get(int fbID)
        {
            return Ok(_db.Feedback.Where(fb => fb.FeedbackId == fbID));
        }

        [HttpPost]
        public async Task<ActionResult<Feedback>> Post([FromBody] Feedback fb)
        {
            _db.Feedback.Add(fb);
            await _db.SaveChangesAsync();
            return Created("Created feedback", fb);
        }

    }
}
