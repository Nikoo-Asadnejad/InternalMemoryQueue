# InternalMemoryQueue

This library will make an internal queue and publish your event into it, the queue will be processed in background.

<h3> How To Add It ? </h3>

To Add <code>InternalMemoryQueue</code>  and <code>InternalEventBus</code>  to your application just add following code to your di:
</br>

`services.InjectInternalEventBus();`
</br>

`InjectInternalEventBus()` is a extention method on `IServiceCollection` :

<h3> How To Use It ? </h3>
<ol>
    <li>Create your event by inheriting from <code>IInternalEvent</code>.</li>
    <li>Create your event handler by inheriting from <code>IIEventHandler</code>.</li>
    <li>Inject <code>IEventBus</code> into your service.</li>
    <li>Call the <code>Publish</code> method of <code>eventBus</code> and pass your event to it.</li>
</ol>


