using Net6SpaTemplate.BLL;
using Net6SpaTemplate.BLL.Client;
using Net6SpaTemplate.DAL;
using Net6SpaTemplate.WebHost;
using Scrutor;
using System.CodeDom.Compiler;

namespace Net6SpaTemplate
{
    public static class ServiceRegistry
    {
        public static void ScanForAllRemainingRegistrations(IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromAssembliesOf(typeof(Program), typeof(TestFacade), typeof(TestRepository))
                .AddClasses(x => x.WithoutAttribute<GeneratedCodeAttribute>())
                .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        }

        public static void AddConfig(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(provider => configuration.GetSection("AppConfig").Bind(provider));
            services.Configure<APIKeys>(provider => configuration.GetSection("APIKeys").Bind(provider));
            services.AddSingleton(_ => new FoodApiConfig { BaseUrl = configuration["Services:FoodApi"] });
        }

        public static void AddForwardedHeaderOptions(IServiceCollection services)
        {
         
        }

        public static void AddRestClients(IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IClient, Client>();
        }

    }
}

