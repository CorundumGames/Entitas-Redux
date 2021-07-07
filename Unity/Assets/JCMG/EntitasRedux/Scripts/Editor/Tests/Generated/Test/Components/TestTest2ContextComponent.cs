public partial class TestEntity
{
	public EntitasRedux.Tests.Test2ContextComponent Test2Context { get { return (EntitasRedux.Tests.Test2ContextComponent)GetComponent(TestComponentsLookup.Test2Context); } }
	public bool HasTest2Context { get { return HasComponent(TestComponentsLookup.Test2Context); } }

	public void AddTest2Context(string newValue)
	{
		var index = TestComponentsLookup.Test2Context;
		var component = (EntitasRedux.Tests.Test2ContextComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Test2ContextComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceTest2Context(string newValue)
	{
		var index = TestComponentsLookup.Test2Context;
		var component = (EntitasRedux.Tests.Test2ContextComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Test2ContextComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyTest2ContextTo(EntitasRedux.Tests.Test2ContextComponent copyComponent)
	{
		var index = TestComponentsLookup.Test2Context;
		var component = (EntitasRedux.Tests.Test2ContextComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Test2ContextComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveTest2Context()
	{
		RemoveComponent(TestComponentsLookup.Test2Context);
	}
}

public partial class TestEntity : ITest2ContextEntity { }

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherTest2Context;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> Test2Context
	{
		get
		{
			if (_matcherTest2Context == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.Test2Context);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherTest2Context = matcher;
			}

			return _matcherTest2Context;
		}
	}
}
