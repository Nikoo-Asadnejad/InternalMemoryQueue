

# Internal Memory Queue and Event Bus Library

This library provides an internal queue system that publishes events into it, allowing the queue to be processed in the background for efficient event handling.

## How To Add It

To integrate `InternalMemoryQueue` and `InternalEventBus` into your application, simply add the following code to your dependency injection (DI) setup:

```csharp
services.InjectInternalEventBus();
```

`InjectInternalEventBus()` is an extension method available on `IServiceCollection`.

## How To Use It

1. **Create Your Event**: Inherit from `IInternalEvent` to define your custom event.
2. **Create Your Event Handler**: Inherit from `IIEventHandler` to implement your event handling logic.
3. **Inject IEventBus**: Add `IEventBus` to your service through dependency injection.
4. **Publish Your Event**: Call the `Publish` method on `eventBus` and pass your event instance to it.

This streamlined process ensures your application can handle events asynchronously, enhancing performance and responsiveness.
