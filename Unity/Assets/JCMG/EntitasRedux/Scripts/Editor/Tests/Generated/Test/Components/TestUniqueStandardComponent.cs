public partial class TestContext {

	public TestEntity UniqueStandardEntity { get { return GetGroup(TestMatcher.UniqueStandard).GetSingleEntity(); } }
	public EntitasRedux.Tests.UniqueStandardComponent UniqueStandard { get { return UniqueStandardEntity.UniqueStandard; } }
	public bool HasUniqueStandard { get { return UniqueStandardEntity != null; } }

	public TestEntity SetUniqueStandard(string newValue)
	{
		if (HasUniqueStandard)
		{
			throw new JCMG.EntitasRedux.EntitasReduxException(
				"Could not set UniqueStandard!\n" +
				this +
				" already has an entity with EntitasRedux.Tests.UniqueStandardComponent!",
				"You should check if the context already has a UniqueStandardEntity before setting it or use context.ReplaceUniqueStandard().");
		}
		var entity = CreateEntity();
		#if !ENTITAS_REDUX_NO_IMPL
		entity.AddUniqueStandard(newValue);
		#endif
		return entity;
	}

	public void ReplaceUniqueStandard(string newValue)
	{
		#if !ENTITAS_REDUX_NO_IMPL
		var entity = UniqueStandardEntity;
		if (entity == null)
		{
			entity = SetUniqueStandard(newValue);
		}
		else
		{
			entity.ReplaceUniqueStandard(newValue);
		}
		#endif
	}

	public void RemoveUniqueStandard()
	{
		UniqueStandardEntity.Destroy();
	}
}

public partial class TestEntity
{
	public EntitasRedux.Tests.UniqueStandardComponent UniqueStandard { get { return (EntitasRedux.Tests.UniqueStandardComponent)GetComponent(TestComponentsLookup.UniqueStandard); } }
	public bool HasUniqueStandard { get { return HasComponent(TestComponentsLookup.UniqueStandard); } }

	public void AddUniqueStandard(string newValue)
	{
		var index = TestComponentsLookup.UniqueStandard;
		var component = (EntitasRedux.Tests.UniqueStandardComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueStandardComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceUniqueStandard(string newValue)
	{
		var index = TestComponentsLookup.UniqueStandard;
		var component = (EntitasRedux.Tests.UniqueStandardComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueStandardComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyUniqueStandardTo(EntitasRedux.Tests.UniqueStandardComponent copyComponent)
	{
		var index = TestComponentsLookup.UniqueStandard;
		var component = (EntitasRedux.Tests.UniqueStandardComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueStandardComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveUniqueStandard()
	{
		RemoveComponent(TestComponentsLookup.UniqueStandard);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherUniqueStandard;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> UniqueStandard
	{
		get
		{
			if (_matcherUniqueStandard == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.UniqueStandard);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherUniqueStandard = matcher;
			}

			return _matcherUniqueStandard;
		}
	}
}
