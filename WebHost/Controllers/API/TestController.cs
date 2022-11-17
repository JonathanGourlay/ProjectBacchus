using Microsoft.AspNetCore.Mvc;
using Net6SpaTemplate.BLL;
using Net6SpaTemplate.BLL.Client;
using System.Net;

namespace Net6SpaTemplate.WebHost.Controllers.API
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestFacade _testFacade;
        public TestController(ITestFacade testFacade)
        {
            _testFacade = testFacade;
        }

        [HttpGet("GetRecipies")]
        [ProducesResponseType(typeof(IEnumerable<BLL.Recipe>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetReciipes([FromQuery] string search)
        {
            var response = await _testFacade.GetRecipie(search);
            return Ok(response);
        }
    }
}
