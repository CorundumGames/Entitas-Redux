public partial class MyTestEntity
{
	public EntitasRedux.Tests.Array3dComponent Array3d { get { return (EntitasRedux.Tests.Array3dComponent)GetComponent(MyTestComponentsLookup.Array3d); } }
	public bool HasArray3d { get { return HasComponent(MyTestComponentsLookup.Array3d); } }

	public void AddArray3d(int[,,] newValue)
	{
		var index = MyTestComponentsLookup.Array3d;
		var component = (EntitasRedux.Tests.Array3dComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Array3dComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceArray3d(int[,,] newValue)
	{
		var index = MyTestComponentsLookup.Array3d;
		var component = (EntitasRedux.Tests.Array3dComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Array3dComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyArray3dTo(EntitasRedux.Tests.Array3dComponent copyComponent)
	{
		var index = MyTestComponentsLookup.Array3d;
		var component = (EntitasRedux.Tests.Array3dComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Array3dComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = (int[,,])copyComponent.value.Clone();
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveArray3d()
	{
		RemoveComponent(MyTestComponentsLookup.Array3d);
	}
}

public sealed partial class MyTestMatcher
{
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherArray3d;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> Array3d
	{
		get
		{
			if (_matcherArray3d == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.Array3d);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherArray3d = matcher;
			}

			return _matcherArray3d;
		}
	}
}
