public partial class TestEntity
{
	public TestAnyMultipleContextStandardEventAddedListenerComponent TestAnyMultipleContextStandardEventAddedListener { get { return (TestAnyMultipleContextStandardEventAddedListenerComponent)GetComponent(TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener); } }
	public bool HasTestAnyMultipleContextStandardEventAddedListener { get { return HasComponent(TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener); } }

	public void AddTestAnyMultipleContextStandardEventAddedListener(System.Collections.Generic.List<ITestAnyMultipleContextStandardEventAddedListener> newValue)
	{
		var index = TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener;
		var component = (TestAnyMultipleContextStandardEventAddedListenerComponent)CreateComponent(index, typeof(TestAnyMultipleContextStandardEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceTestAnyMultipleContextStandardEventAddedListener(System.Collections.Generic.List<ITestAnyMultipleContextStandardEventAddedListener> newValue)
	{
		var index = TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener;
		var component = (TestAnyMultipleContextStandardEventAddedListenerComponent)CreateComponent(index, typeof(TestAnyMultipleContextStandardEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyTestAnyMultipleContextStandardEventAddedListenerTo(TestAnyMultipleContextStandardEventAddedListenerComponent copyComponent)
	{
		var index = TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener;
		var component = (TestAnyMultipleContextStandardEventAddedListenerComponent)CreateComponent(index, typeof(TestAnyMultipleContextStandardEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveTestAnyMultipleContextStandardEventAddedListener()
	{
		RemoveComponent(TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherTestAnyMultipleContextStandardEventAddedListener;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> TestAnyMultipleContextStandardEventAddedListener
	{
		get
		{
			if (_matcherTestAnyMultipleContextStandardEventAddedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherTestAnyMultipleContextStandardEventAddedListener = matcher;
			}

			return _matcherTestAnyMultipleContextStandardEventAddedListener;
		}
	}
}

public partial class TestEntity
{
	public void AddTestAnyMultipleContextStandardEventAddedListener(ITestAnyMultipleContextStandardEventAddedListener value)
	{
		var listeners = HasTestAnyMultipleContextStandardEventAddedListener
			? TestAnyMultipleContextStandardEventAddedListener.value
			: new System.Collections.Generic.List<ITestAnyMultipleContextStandardEventAddedListener>();
		listeners.Add(value);
		ReplaceTestAnyMultipleContextStandardEventAddedListener(listeners);
	}

	public void RemoveTestAnyMultipleContextStandardEventAddedListener(ITestAnyMultipleContextStandardEventAddedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = TestAnyMultipleContextStandardEventAddedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveTestAnyMultipleContextStandardEventAddedListener();
		}
		else
		{
			ReplaceTestAnyMultipleContextStandardEventAddedListener(listeners);
		}
	}
}
