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
	public ExampleContent.VisualDebugging.MyEventComponent MyEvent { get { return (ExampleContent.VisualDebugging.MyEventComponent)GetComponent(VisualDebugComponentsLookup.MyEvent); } }
	public bool HasMyEvent { get { return HasComponent(VisualDebugComponentsLookup.MyEvent); } }

	public void AddMyEvent(string newValue)
	{
		var index = VisualDebugComponentsLookup.MyEvent;
		var component = (ExampleContent.VisualDebugging.MyEventComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMyEvent(string newValue)
	{
		var index = VisualDebugComponentsLookup.MyEvent;
		var component = (ExampleContent.VisualDebugging.MyEventComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMyEventTo(ExampleContent.VisualDebugging.MyEventComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.MyEvent;
		var component = (ExampleContent.VisualDebugging.MyEventComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMyEvent()
	{
		RemoveComponent(VisualDebugComponentsLookup.MyEvent);
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
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyEvent;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyEvent
	{
		get
		{
			if (_matcherMyEvent == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyEvent);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherMyEvent = matcher;
			}

			return _matcherMyEvent;
		}
	}
}
