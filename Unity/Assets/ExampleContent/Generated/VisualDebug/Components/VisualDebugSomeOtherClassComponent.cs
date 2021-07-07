public partial class VisualDebugEntity
{
	public SomeOtherClassComponent SomeOtherClass { get { return (SomeOtherClassComponent)GetComponent(VisualDebugComponentsLookup.SomeOtherClass); } }
	public bool HasSomeOtherClass { get { return HasComponent(VisualDebugComponentsLookup.SomeOtherClass); } }

	public void AddSomeOtherClass(ExampleContent.VisualDebugging.SomeOtherClass newValue)
	{
		var index = VisualDebugComponentsLookup.SomeOtherClass;
		var component = (SomeOtherClassComponent)CreateComponent(index, typeof(SomeOtherClassComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceSomeOtherClass(ExampleContent.VisualDebugging.SomeOtherClass newValue)
	{
		var index = VisualDebugComponentsLookup.SomeOtherClass;
		var component = (SomeOtherClassComponent)CreateComponent(index, typeof(SomeOtherClassComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopySomeOtherClassTo(SomeOtherClassComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.SomeOtherClass;
		var component = (SomeOtherClassComponent)CreateComponent(index, typeof(SomeOtherClassComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = (ExampleContent.VisualDebugging.SomeOtherClass)copyComponent.value.Clone();
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveSomeOtherClass()
	{
		RemoveComponent(VisualDebugComponentsLookup.SomeOtherClass);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherSomeOtherClass;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> SomeOtherClass
	{
		get
		{
			if (_matcherSomeOtherClass == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.SomeOtherClass);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherSomeOtherClass = matcher;
			}

			return _matcherSomeOtherClass;
		}
	}
}
