//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity
{
	public EntitasRedux.Tests.EntityIndexComponent EntityIndex { get { return (EntitasRedux.Tests.EntityIndexComponent)GetComponent(TestComponentsLookup.EntityIndex); } }
	public bool HasEntityIndex { get { return HasComponent(TestComponentsLookup.EntityIndex); } }

	public void AddEntityIndex(string newValue)
	{
		var index = TestComponentsLookup.EntityIndex;
		var component = (EntitasRedux.Tests.EntityIndexComponent)CreateComponent(index, typeof(EntitasRedux.Tests.EntityIndexComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceEntityIndex(string newValue)
	{
		var index = TestComponentsLookup.EntityIndex;
		var component = (EntitasRedux.Tests.EntityIndexComponent)CreateComponent(index, typeof(EntitasRedux.Tests.EntityIndexComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyEntityIndexTo(EntitasRedux.Tests.EntityIndexComponent copyComponent)
	{
		var index = TestComponentsLookup.EntityIndex;
		var component = (EntitasRedux.Tests.EntityIndexComponent)CreateComponent(index, typeof(EntitasRedux.Tests.EntityIndexComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveEntityIndex()
	{
		RemoveComponent(TestComponentsLookup.EntityIndex);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity : IEntityIndexEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherEntityIndex;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> EntityIndex
	{
		get
		{
			if (_matcherEntityIndex == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.EntityIndex);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherEntityIndex = matcher;
			}

			return _matcherEntityIndex;
		}
	}
}
