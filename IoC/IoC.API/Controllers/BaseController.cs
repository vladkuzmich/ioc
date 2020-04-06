using System;
using Microsoft.AspNetCore.Mvc;
using IoC.Business.Contracts;
using Microsoft.Extensions.Logging;

namespace IoC.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected ITestService TestService;
        protected ILogger<BaseController> Logger;

        public BaseController(
            ITestService testService,
            ILogger<BaseController> logger)
        {
            TestService = testService ?? throw new ArgumentNullException(nameof(testService));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
