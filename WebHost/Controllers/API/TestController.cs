using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Net6SpaTemplate.WebHost.Controllers.API
{
    [ApiController]
    [Route("testing")]
    public class TestController : ControllerBase
    {
        public TestController()
        {
        }

        [HttpGet("spades")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Test()
        {
            return Ok("Hello from the API");
        }
    }
}
