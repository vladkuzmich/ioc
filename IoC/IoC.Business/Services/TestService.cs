using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using IoC.Business.Contracts;
using IoC.Data.Contracts;

namespace IoC.Business.Services
{
    public class TestService : ITestService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IUserRepository _userRepository;
        private readonly IEnumerable<INotificator> _notifications;
        private readonly ILogger<TestService> _logger;

        public TestService(
            ICompanyRepository companyRepository,
            IUserRepository userRepository,
            IEnumerable<INotificator> notifications,
            ILogger<TestService> logger)
        {
            _companyRepository = companyRepository ?? throw new ArgumentNullException(nameof(companyRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _notifications = notifications ?? throw new ArgumentNullException(nameof(notifications));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}