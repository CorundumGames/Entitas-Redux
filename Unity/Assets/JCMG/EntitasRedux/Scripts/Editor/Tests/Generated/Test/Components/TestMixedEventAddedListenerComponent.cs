public partial class TestEntity
{
	public MixedEventAddedListenerComponent MixedEventAddedListener { get { return (MixedEventAddedListenerComponent)GetComponent(TestComponentsLookup.MixedEventAddedListener); } }
	public bool HasMixedEventAddedListener { get { return HasComponent(TestComponentsLookup.MixedEventAddedListener); } }

	public void AddMixedEventAddedListener(System.Collections.Generic.List<IMixedEventAddedListener> newValue)
	{
		var index = TestComponentsLookup.MixedEventAddedListener;
		var component = (MixedEventAddedListenerComponent)CreateComponent(index, typeof(MixedEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMixedEventAddedListener(System.Collections.Generic.List<IMixedEventAddedListener> newValue)
	{
		var index = TestComponentsLookup.MixedEventAddedListener;
		var component = (MixedEventAddedListenerComponent)CreateComponent(index, typeof(MixedEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMixedEventAddedListenerTo(MixedEventAddedListenerComponent copyComponent)
	{
		var index = TestComponentsLookup.MixedEventAddedListener;
		var component = (MixedEventAddedListenerComponent)CreateComponent(index, typeof(MixedEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMixedEventAddedListener()
	{
		RemoveComponent(TestComponentsLookup.MixedEventAddedListener);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherMixedEventAddedListener;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> MixedEventAddedListener
	{
		get
		{
			if (_matcherMixedEventAddedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.MixedEventAddedListener);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherMixedEventAddedListener = matcher;
			}

			return _matcherMixedEventAddedListener;
		}
	}
}

public partial class TestEntity
{
	public void AddMixedEventAddedListener(IMixedEventAddedListener value)
	{
		var listeners = HasMixedEventAddedListener
			? MixedEventAddedListener.value
			: new System.Collections.Generic.List<IMixedEventAddedListener>();
		listeners.Add(value);
		ReplaceMixedEventAddedListener(listeners);
	}

	public void RemoveMixedEventAddedListener(IMixedEventAddedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = MixedEventAddedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveMixedEventAddedListener();
		}
		else
		{
			ReplaceMixedEventAddedListener(listeners);
		}
	}
}
