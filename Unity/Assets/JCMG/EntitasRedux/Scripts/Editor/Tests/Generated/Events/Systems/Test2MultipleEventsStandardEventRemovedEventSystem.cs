public sealed class Test2MultipleEventsStandardEventRemovedEventSystem : JCMG.EntitasRedux.ReactiveSystem<Test2Entity>
{
	readonly System.Collections.Generic.List<ITest2MultipleEventsStandardEventRemovedListener> _listenerBuffer;

	public Test2MultipleEventsStandardEventRemovedEventSystem(Contexts contexts) : base(contexts.Test2)
	{
		_listenerBuffer = new System.Collections.Generic.List<ITest2MultipleEventsStandardEventRemovedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<Test2Entity> GetTrigger(JCMG.EntitasRedux.IContext<Test2Entity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Removed(Test2Matcher.MultipleEventsStandardEvent)
		);
	}

	protected override bool Filter(Test2Entity entity)
	{
		return !entity.HasMultipleEventsStandardEvent && entity.HasTest2MultipleEventsStandardEventRemovedListener;
	}

	protected override void Execute(System.Collections.Generic.List<Test2Entity> entities)
	{
		foreach (var e in entities)
		{
			
			_listenerBuffer.Clear();
			_listenerBuffer.AddRange(e.Test2MultipleEventsStandardEventRemovedListener.value);
			foreach (var listener in _listenerBuffer)
			{
				listener.OnMultipleEventsStandardEventRemoved(e);
			}
		}
	}
}
