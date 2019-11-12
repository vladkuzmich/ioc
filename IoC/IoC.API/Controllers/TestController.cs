using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using IoC.Business.Contracts;
using Microsoft.Extensions.Logging;

namespace IoC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly ILogger<TestController> _logger;

        public TestController(
            ITestService testService,
            ILogger<TestController> logger)
        {
            _testService = testService ?? throw new ArgumentNullException(nameof(testService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET api/test
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.LogInformation("Test endpoint was called");

            return new[] { "value1", "value2" };
        } 
    }
}