public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.Vector3Component Vector3 { get { return (ExampleContent.VisualDebugging.Vector3Component)GetComponent(VisualDebugComponentsLookup.Vector3); } }
	public bool HasVector3 { get { return HasComponent(VisualDebugComponentsLookup.Vector3); } }

	public void AddVector3(UnityEngine.Vector3 newVector3)
	{
		var index = VisualDebugComponentsLookup.Vector3;
		var component = (ExampleContent.VisualDebugging.Vector3Component)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Vector3Component));
		#if !ENTITAS_REDUX_NO_IMPL
		component.vector3 = newVector3;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceVector3(UnityEngine.Vector3 newVector3)
	{
		var index = VisualDebugComponentsLookup.Vector3;
		var component = (ExampleContent.VisualDebugging.Vector3Component)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Vector3Component));
		#if !ENTITAS_REDUX_NO_IMPL
		component.vector3 = newVector3;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyVector3To(ExampleContent.VisualDebugging.Vector3Component copyComponent)
	{
		var index = VisualDebugComponentsLookup.Vector3;
		var component = (ExampleContent.VisualDebugging.Vector3Component)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Vector3Component));
		#if !ENTITAS_REDUX_NO_IMPL
		component.vector3 = copyComponent.vector3;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveVector3()
	{
		RemoveComponent(VisualDebugComponentsLookup.Vector3);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherVector3;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Vector3
	{
		get
		{
			if (_matcherVector3 == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Vector3);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherVector3 = matcher;
			}

			return _matcherVector3;
		}
	}
}
