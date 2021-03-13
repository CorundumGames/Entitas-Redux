//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MyTestEntity
{
	public EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent MultiplePrimaryEntityIndices { get { return (EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent)GetComponent(MyTestComponentsLookup.MultiplePrimaryEntityIndices); } }
	public bool HasMultiplePrimaryEntityIndices { get { return HasComponent(MyTestComponentsLookup.MultiplePrimaryEntityIndices); } }

	public void AddMultiplePrimaryEntityIndices(string newValue, string newValue2)
	{
		var index = MyTestComponentsLookup.MultiplePrimaryEntityIndices;
		var component = (EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent)CreateComponent(index, typeof(EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		component.value2 = newValue2;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMultiplePrimaryEntityIndices(string newValue, string newValue2)
	{
		var index = MyTestComponentsLookup.MultiplePrimaryEntityIndices;
		var component = (EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent)CreateComponent(index, typeof(EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		component.value2 = newValue2;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMultiplePrimaryEntityIndicesTo(EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent copyComponent)
	{
		var index = MyTestComponentsLookup.MultiplePrimaryEntityIndices;
		var component = (EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent)CreateComponent(index, typeof(EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		component.value2 = copyComponent.value2;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMultiplePrimaryEntityIndices()
	{
		RemoveComponent(MyTestComponentsLookup.MultiplePrimaryEntityIndices);
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
public sealed partial class MyTestMatcher
{
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherMultiplePrimaryEntityIndices;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> MultiplePrimaryEntityIndices
	{
		get
		{
			if (_matcherMultiplePrimaryEntityIndices == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.MultiplePrimaryEntityIndices);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherMultiplePrimaryEntityIndices = matcher;
			}

			return _matcherMultiplePrimaryEntityIndices;
		}
	}
}
