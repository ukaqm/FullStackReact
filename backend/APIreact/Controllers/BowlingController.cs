using APIreact.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIreact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingController(IBowlingRepository temp) 
        {
            _bowlingRepository = temp;
        }

        //[HttpGet]
        //public IEnumerable<Bowler> Get()
        //{
        //    var bowlingData = _bowlingRepository.Bowlers.ToArray();
        //
        //    return bowlingData;
        //}

        [HttpGet("marlins-sharks")]
        public IActionResult GetBowlersForMarlinsAndSharks() 
        {
            var bowlers = _bowlingRepository.GetBowlersForMarlinsAndSharks();
            return Ok(bowlers);
        }
    }
}
