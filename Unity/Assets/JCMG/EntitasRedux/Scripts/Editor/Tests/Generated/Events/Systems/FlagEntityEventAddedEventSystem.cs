public sealed class FlagEntityEventAddedEventSystem : JCMG.EntitasRedux.ReactiveSystem<TestEntity>
{
	readonly System.Collections.Generic.List<IFlagEntityEventAddedListener> _listenerBuffer;

	public FlagEntityEventAddedEventSystem(Contexts contexts) : base(contexts.Test)
	{
		_listenerBuffer = new System.Collections.Generic.List<IFlagEntityEventAddedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<TestEntity> GetTrigger(JCMG.EntitasRedux.IContext<TestEntity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(TestMatcher.FlagEntityEvent)
		);
	}

	protected override bool Filter(TestEntity entity)
	{
		return entity.IsFlagEntityEvent && entity.HasFlagEntityEventAddedListener;
	}

	protected override void Execute(System.Collections.Generic.List<TestEntity> entities)
	{
		foreach (var e in entities)
		{
			
			_listenerBuffer.Clear();
			_listenerBuffer.AddRange(e.FlagEntityEventAddedListener.value);
			foreach (var listener in _listenerBuffer)
			{
				listener.OnFlagEntityEventAdded(e);
			}
		}
	}
}
