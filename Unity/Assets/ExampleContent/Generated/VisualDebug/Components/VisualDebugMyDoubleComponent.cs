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
	public ExampleContent.VisualDebugging.MyDoubleComponent MyDouble { get { return (ExampleContent.VisualDebugging.MyDoubleComponent)GetComponent(VisualDebugComponentsLookup.MyDouble); } }
	public bool HasMyDouble { get { return HasComponent(VisualDebugComponentsLookup.MyDouble); } }

	public void AddMyDouble(double newMyDouble)
	{
		var index = VisualDebugComponentsLookup.MyDouble;
		var component = (ExampleContent.VisualDebugging.MyDoubleComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyDoubleComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myDouble = newMyDouble;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMyDouble(double newMyDouble)
	{
		var index = VisualDebugComponentsLookup.MyDouble;
		var component = (ExampleContent.VisualDebugging.MyDoubleComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyDoubleComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myDouble = newMyDouble;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMyDoubleTo(ExampleContent.VisualDebugging.MyDoubleComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.MyDouble;
		var component = (ExampleContent.VisualDebugging.MyDoubleComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyDoubleComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myDouble = copyComponent.myDouble;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMyDouble()
	{
		RemoveComponent(VisualDebugComponentsLookup.MyDouble);
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
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyDouble;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyDouble
	{
		get
		{
			if (_matcherMyDouble == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyDouble);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherMyDouble = matcher;
			}

			return _matcherMyDouble;
		}
	}
}
