public sealed class AnyMyEventAddedEventSystem : JCMG.EntitasRedux.ReactiveSystem<VisualDebugEntity>
{
	readonly JCMG.EntitasRedux.IGroup<VisualDebugEntity> _listeners;
	readonly System.Collections.Generic.List<VisualDebugEntity> _entityBuffer;
	readonly System.Collections.Generic.List<IAnyMyEventAddedListener> _listenerBuffer;

	public AnyMyEventAddedEventSystem(Contexts contexts) : base(contexts.VisualDebug)
	{
		_listeners = contexts.VisualDebug.GetGroup(VisualDebugMatcher.AnyMyEventAddedListener);
		_entityBuffer = new System.Collections.Generic.List<VisualDebugEntity>();
		_listenerBuffer = new System.Collections.Generic.List<IAnyMyEventAddedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<VisualDebugEntity> GetTrigger(JCMG.EntitasRedux.IContext<VisualDebugEntity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(VisualDebugMatcher.MyEvent)
		);
	}

	protected override bool Filter(VisualDebugEntity entity)
	{
		return entity.HasMyEvent;
	}

	protected override void Execute(System.Collections.Generic.List<VisualDebugEntity> entities)
	{
		foreach (var e in entities)
		{
			var component = e.MyEvent;
			foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer))
			{
				_listenerBuffer.Clear();
				_listenerBuffer.AddRange(listenerEntity.AnyMyEventAddedListener.value);
				foreach (var listener in _listenerBuffer)
				{
					listener.OnAnyMyEventAdded(e, component.value);
				}
			}
		}
	}
}
