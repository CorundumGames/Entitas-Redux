public partial class MyTestEntity
{
	public EntitasRedux.Tests.DeepCopyComponent DeepCopy { get { return (EntitasRedux.Tests.DeepCopyComponent)GetComponent(MyTestComponentsLookup.DeepCopy); } }
	public bool HasDeepCopy { get { return HasComponent(MyTestComponentsLookup.DeepCopy); } }

	public void AddDeepCopy(EntitasRedux.Tests.CloneableObject newValue, System.Collections.Generic.List<EntitasRedux.Tests.CloneableObject> newList, System.Collections.Generic.Dictionary<EntitasRedux.Tests.CloneableObject, EntitasRedux.Tests.CloneableObject> newDict)
	{
		var index = MyTestComponentsLookup.DeepCopy;
		var component = (EntitasRedux.Tests.DeepCopyComponent)CreateComponent(index, typeof(EntitasRedux.Tests.DeepCopyComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		component.list = newList;
		component.dict = newDict;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceDeepCopy(EntitasRedux.Tests.CloneableObject newValue, System.Collections.Generic.List<EntitasRedux.Tests.CloneableObject> newList, System.Collections.Generic.Dictionary<EntitasRedux.Tests.CloneableObject, EntitasRedux.Tests.CloneableObject> newDict)
	{
		var index = MyTestComponentsLookup.DeepCopy;
		var component = (EntitasRedux.Tests.DeepCopyComponent)CreateComponent(index, typeof(EntitasRedux.Tests.DeepCopyComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		component.list = newList;
		component.dict = newDict;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyDeepCopyTo(EntitasRedux.Tests.DeepCopyComponent copyComponent)
	{
		var index = MyTestComponentsLookup.DeepCopy;
		var component = (EntitasRedux.Tests.DeepCopyComponent)CreateComponent(index, typeof(EntitasRedux.Tests.DeepCopyComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = (EntitasRedux.Tests.CloneableObject)copyComponent.value.Clone();
		component.list = (System.Collections.Generic.List<EntitasRedux.Tests.CloneableObject>)JCMG.EntitasRedux.ListTools.DeepCopy(copyComponent.list);
		component.dict = (System.Collections.Generic.Dictionary<EntitasRedux.Tests.CloneableObject, EntitasRedux.Tests.CloneableObject>)JCMG.EntitasRedux.DictionaryTools.DeepCopy(copyComponent.dict);
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveDeepCopy()
	{
		RemoveComponent(MyTestComponentsLookup.DeepCopy);
	}
}

public sealed partial class MyTestMatcher
{
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherDeepCopy;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> DeepCopy
	{
		get
		{
			if (_matcherDeepCopy == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.DeepCopy);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherDeepCopy = matcher;
			}

			return _matcherDeepCopy;
		}
	}
}
