public partial class TestEntity
{
	public NewCustomNameComponent1Component NewCustomNameComponent1 { get { return (NewCustomNameComponent1Component)GetComponent(TestComponentsLookup.NewCustomNameComponent1); } }
	public bool HasNewCustomNameComponent1 { get { return HasComponent(TestComponentsLookup.NewCustomNameComponent1); } }

	public void AddNewCustomNameComponent1(EntitasRedux.Tests.CustomName newValue)
	{
		var index = TestComponentsLookup.NewCustomNameComponent1;
		var component = (NewCustomNameComponent1Component)CreateComponent(index, typeof(NewCustomNameComponent1Component));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceNewCustomNameComponent1(EntitasRedux.Tests.CustomName newValue)
	{
		var index = TestComponentsLookup.NewCustomNameComponent1;
		var component = (NewCustomNameComponent1Component)CreateComponent(index, typeof(NewCustomNameComponent1Component));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyNewCustomNameComponent1To(NewCustomNameComponent1Component copyComponent)
	{
		var index = TestComponentsLookup.NewCustomNameComponent1;
		var component = (NewCustomNameComponent1Component)CreateComponent(index, typeof(NewCustomNameComponent1Component));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveNewCustomNameComponent1()
	{
		RemoveComponent(TestComponentsLookup.NewCustomNameComponent1);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherNewCustomNameComponent1;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> NewCustomNameComponent1
	{
		get
		{
			if (_matcherNewCustomNameComponent1 == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.NewCustomNameComponent1);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherNewCustomNameComponent1 = matcher;
			}

			return _matcherNewCustomNameComponent1;
		}
	}
}
