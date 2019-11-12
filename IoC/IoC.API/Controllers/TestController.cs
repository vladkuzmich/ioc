using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using IoC.Business.Contracts;

namespace IoC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService ?? throw new ArgumentNullException(nameof(testService));
        }

        // GET api/test
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => new[] { "value1", "value2" };
    }
}