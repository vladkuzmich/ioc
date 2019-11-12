using Microsoft.Extensions.DependencyInjection;
using IoC.Data;
using IoC.Data.Repositories;
using IoC.Business.Contracts;
using IoC.Business.Notifications;
using IoC.Business.Services;
using Microsoft.EntityFrameworkCore;

namespace IoC.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private const string RepositoryRestrictionPattern = "Repository";
        private const string ServiceRestrictionPattern = "Service";

        public static void AddRegistrations(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddScoped<DbContext, ApplicationContext>()
                .Scan(scan => scan
                    .FromAssembliesOf(typeof(BaseRepository<>))
                    .AddClasses(classes => classes.Where(type => type.Name.EndsWith(RepositoryRestrictionPattern)))
                    .AsImplementedInterfaces()
                    .WithScopedLifetime()

                    .FromAssembliesOf(typeof(TestService))
                    .AddClasses(classes => classes.Where(type => type.Name.EndsWith(ServiceRestrictionPattern)))
                    .AsImplementedInterfaces()
                    .WithScopedLifetime()

                    .FromAssembliesOf(typeof(SmsNotificator))
                    .AddClasses(classes => classes.AssignableTo(typeof(INotificator)))
                    .AsImplementedInterfaces()
                    .WithSingletonLifetime());
        }

    }
}