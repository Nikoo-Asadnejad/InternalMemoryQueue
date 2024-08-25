# InternalMemoryQueue



To Add InternalMemoryQueue and InternalEventBus to your application just add following code to your di:
</br>

InjectInternalEventBus is a extention method on IServiceCollection :
</br>
`services.InjectInternalEventBus();`

<h3> How To Use It ? </h3>
<ol> Create your event by inheriting from IInternalEvent </ol>
<ol> Create your event handler by inheriting from IIEventHandler </ol>
<ol> Inject IEventBus into your service </ol>
<ol> Call Publish method of eventBus and pass your event to it </ol>


