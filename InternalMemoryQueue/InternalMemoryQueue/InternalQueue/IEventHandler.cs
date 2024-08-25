using MediatR;

namespace InternalMemoryQueue.InternalQueue;

public interface IEventHandler<T> : INotificationHandler<T> where T : IInternalEvent 
{
    
}