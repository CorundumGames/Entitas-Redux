public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.MyFloatComponent MyFloat { get { return (ExampleContent.VisualDebugging.MyFloatComponent)GetComponent(VisualDebugComponentsLookup.MyFloat); } }
	public bool HasMyFloat { get { return HasComponent(VisualDebugComponentsLookup.MyFloat); } }

	public void AddMyFloat(float newMyFloat)
	{
		var index = VisualDebugComponentsLookup.MyFloat;
		var component = (ExampleContent.VisualDebugging.MyFloatComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyFloatComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myFloat = newMyFloat;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMyFloat(float newMyFloat)
	{
		var index = VisualDebugComponentsLookup.MyFloat;
		var component = (ExampleContent.VisualDebugging.MyFloatComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyFloatComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myFloat = newMyFloat;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMyFloatTo(ExampleContent.VisualDebugging.MyFloatComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.MyFloat;
		var component = (ExampleContent.VisualDebugging.MyFloatComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyFloatComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myFloat = copyComponent.myFloat;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMyFloat()
	{
		RemoveComponent(VisualDebugComponentsLookup.MyFloat);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyFloat;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyFloat
	{
		get
		{
			if (_matcherMyFloat == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyFloat);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherMyFloat = matcher;
			}

			return _matcherMyFloat;
		}
	}
}
