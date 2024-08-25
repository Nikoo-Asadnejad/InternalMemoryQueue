using InternalMemoryQueue.InternalQueue;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternalMemoryQueue.Configurations;

public static class DIConfigurator
{
    public static void InjectInternalEventBus(this IServiceCollection services )
    {
        services.AddSingleton<InMemoryMessageQueue>();
        services.AddSingleton<IEventBus, EventBus>();
        services.AddHostedService<IntegrationEventProcessor>();
    }
}