namespace InternalMemoryQueue.InternalQueue;

public interface IEventBus
{
    Task PublishAsync<T>(T integrationEvent) where T : IInternalEvent;
}