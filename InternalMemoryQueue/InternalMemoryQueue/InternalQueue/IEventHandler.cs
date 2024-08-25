using MediatR;

namespace InternalMemoryQueue.InternalQueue;

public interface IIEventHandler<T> : INotificationHandler<T> where T : IInternalEvent 
{
    
}