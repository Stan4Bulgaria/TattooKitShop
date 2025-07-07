namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection service)
        {

            return service;
        }
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection service, IConfiguration config)
        {
            return service;
        }
        public static IServiceCollection AddApplicationIndentity(this IServiceCollection service, IConfiguration config)
        {
            return service;
        }
    }
}
