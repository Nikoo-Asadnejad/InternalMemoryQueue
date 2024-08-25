namespace InternalMemoryQueue.InternalQueue;

public sealed record InternalEvent(Guid id) : IInternalEvent;