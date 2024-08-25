namespace InternalMemoryQueue.InternalQueue;

public class EventBus : IEventBus
{
    private readonly InMemoryMessageQueue _queue;

    public EventBus(InMemoryMessageQueue queue)
    {
        _queue = queue;
    }

    public async Task PublishAsync<T>(T integrationEvent) where T: IInternalEvent
    {
        await _queue.Writer.WriteAsync(integrationEvent);
    }
}