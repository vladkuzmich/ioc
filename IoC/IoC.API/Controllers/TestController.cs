using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IoC.Business.Contracts;

namespace IoC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : BaseController
    {
        public TestController(
            ITestService testService,
            ILogger<TestController> logger)
            : base(testService, logger)
        { }

        // GET api/test
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Logger.LogInformation("Test endpoint was called");

            return new[] { "value1", "value2" };
        } 
    }
}