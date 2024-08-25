using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Application.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblyContaining(typeof(ServiceCollectionExtension));
        });

    }
    
}