public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.MyIntComponent MyInt { get { return (ExampleContent.VisualDebugging.MyIntComponent)GetComponent(VisualDebugComponentsLookup.MyInt); } }
	public bool HasMyInt { get { return HasComponent(VisualDebugComponentsLookup.MyInt); } }

	public void AddMyInt(int newMyInt)
	{
		var index = VisualDebugComponentsLookup.MyInt;
		var component = (ExampleContent.VisualDebugging.MyIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyIntComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myInt = newMyInt;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMyInt(int newMyInt)
	{
		var index = VisualDebugComponentsLookup.MyInt;
		var component = (ExampleContent.VisualDebugging.MyIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyIntComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myInt = newMyInt;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMyIntTo(ExampleContent.VisualDebugging.MyIntComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.MyInt;
		var component = (ExampleContent.VisualDebugging.MyIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyIntComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myInt = copyComponent.myInt;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMyInt()
	{
		RemoveComponent(VisualDebugComponentsLookup.MyInt);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyInt;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyInt
	{
		get
		{
			if (_matcherMyInt == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyInt);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherMyInt = matcher;
			}

			return _matcherMyInt;
		}
	}
}
