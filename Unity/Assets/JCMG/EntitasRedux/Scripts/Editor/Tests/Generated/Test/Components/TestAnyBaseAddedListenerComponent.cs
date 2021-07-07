public partial class TestEntity
{
	public AnyBaseAddedListenerComponent AnyBaseAddedListener { get { return (AnyBaseAddedListenerComponent)GetComponent(TestComponentsLookup.AnyBaseAddedListener); } }
	public bool HasAnyBaseAddedListener { get { return HasComponent(TestComponentsLookup.AnyBaseAddedListener); } }

	public void AddAnyBaseAddedListener(System.Collections.Generic.List<IAnyBaseAddedListener> newValue)
	{
		var index = TestComponentsLookup.AnyBaseAddedListener;
		var component = (AnyBaseAddedListenerComponent)CreateComponent(index, typeof(AnyBaseAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceAnyBaseAddedListener(System.Collections.Generic.List<IAnyBaseAddedListener> newValue)
	{
		var index = TestComponentsLookup.AnyBaseAddedListener;
		var component = (AnyBaseAddedListenerComponent)CreateComponent(index, typeof(AnyBaseAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyAnyBaseAddedListenerTo(AnyBaseAddedListenerComponent copyComponent)
	{
		var index = TestComponentsLookup.AnyBaseAddedListener;
		var component = (AnyBaseAddedListenerComponent)CreateComponent(index, typeof(AnyBaseAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveAnyBaseAddedListener()
	{
		RemoveComponent(TestComponentsLookup.AnyBaseAddedListener);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherAnyBaseAddedListener;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> AnyBaseAddedListener
	{
		get
		{
			if (_matcherAnyBaseAddedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.AnyBaseAddedListener);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherAnyBaseAddedListener = matcher;
			}

			return _matcherAnyBaseAddedListener;
		}
	}
}

public partial class TestEntity
{
	public void AddAnyBaseAddedListener(IAnyBaseAddedListener value)
	{
		var listeners = HasAnyBaseAddedListener
			? AnyBaseAddedListener.value
			: new System.Collections.Generic.List<IAnyBaseAddedListener>();
		listeners.Add(value);
		ReplaceAnyBaseAddedListener(listeners);
	}

	public void RemoveAnyBaseAddedListener(IAnyBaseAddedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = AnyBaseAddedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveAnyBaseAddedListener();
		}
		else
		{
			ReplaceAnyBaseAddedListener(listeners);
		}
	}
}
