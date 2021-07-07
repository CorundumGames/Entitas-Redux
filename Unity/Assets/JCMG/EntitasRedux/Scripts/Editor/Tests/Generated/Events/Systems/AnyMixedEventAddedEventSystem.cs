public sealed class AnyMixedEventAddedEventSystem : JCMG.EntitasRedux.ReactiveSystem<TestEntity>
{
	readonly JCMG.EntitasRedux.IGroup<TestEntity> _listeners;
	readonly System.Collections.Generic.List<TestEntity> _entityBuffer;
	readonly System.Collections.Generic.List<IAnyMixedEventAddedListener> _listenerBuffer;

	public AnyMixedEventAddedEventSystem(Contexts contexts) : base(contexts.Test)
	{
		_listeners = contexts.Test.GetGroup(TestMatcher.AnyMixedEventAddedListener);
		_entityBuffer = new System.Collections.Generic.List<TestEntity>();
		_listenerBuffer = new System.Collections.Generic.List<IAnyMixedEventAddedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<TestEntity> GetTrigger(JCMG.EntitasRedux.IContext<TestEntity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(TestMatcher.MixedEvent)
		);
	}

	protected override bool Filter(TestEntity entity)
	{
		return entity.HasMixedEvent;
	}

	protected override void Execute(System.Collections.Generic.List<TestEntity> entities)
	{
		foreach (var e in entities)
		{
			var component = e.MixedEvent;
			foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer))
			{
				_listenerBuffer.Clear();
				_listenerBuffer.AddRange(listenerEntity.AnyMixedEventAddedListener.value);
				foreach (var listener in _listenerBuffer)
				{
					listener.OnAnyMixedEventAdded(e, component.value);
				}
			}
		}
	}
}
