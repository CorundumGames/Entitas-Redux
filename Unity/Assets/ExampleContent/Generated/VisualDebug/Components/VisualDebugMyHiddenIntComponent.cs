//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.MyHiddenIntComponent MyHiddenInt { get { return (ExampleContent.VisualDebugging.MyHiddenIntComponent)GetComponent(VisualDebugComponentsLookup.MyHiddenInt); } }
	public bool HasMyHiddenInt { get { return HasComponent(VisualDebugComponentsLookup.MyHiddenInt); } }

	public void AddMyHiddenInt(int newMyInt)
	{
		var index = VisualDebugComponentsLookup.MyHiddenInt;
		var component = (ExampleContent.VisualDebugging.MyHiddenIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyHiddenIntComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myInt = newMyInt;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMyHiddenInt(int newMyInt)
	{
		var index = VisualDebugComponentsLookup.MyHiddenInt;
		var component = (ExampleContent.VisualDebugging.MyHiddenIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyHiddenIntComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myInt = newMyInt;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMyHiddenIntTo(ExampleContent.VisualDebugging.MyHiddenIntComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.MyHiddenInt;
		var component = (ExampleContent.VisualDebugging.MyHiddenIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyHiddenIntComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myInt = copyComponent.myInt;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMyHiddenInt()
	{
		RemoveComponent(VisualDebugComponentsLookup.MyHiddenInt);
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
public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyHiddenInt;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyHiddenInt
	{
		get
		{
			if (_matcherMyHiddenInt == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyHiddenInt);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherMyHiddenInt = matcher;
			}

			return _matcherMyHiddenInt;
		}
	}
}
