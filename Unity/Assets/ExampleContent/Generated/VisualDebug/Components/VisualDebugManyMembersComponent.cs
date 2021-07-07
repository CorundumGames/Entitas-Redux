public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.ManyMembersComponent ManyMembers { get { return (ExampleContent.VisualDebugging.ManyMembersComponent)GetComponent(VisualDebugComponentsLookup.ManyMembers); } }
	public bool HasManyMembers { get { return HasComponent(VisualDebugComponentsLookup.ManyMembers); } }

	public void AddManyMembers(string newField1, string newField10, string newField11, string newField12, string newField2, string newField3, string newField4, string newField5, string newField6, string newField7, string newField8, string newField9)
	{
		var index = VisualDebugComponentsLookup.ManyMembers;
		var component = (ExampleContent.VisualDebugging.ManyMembersComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.ManyMembersComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.field1 = newField1;
		component.field10 = newField10;
		component.field11 = newField11;
		component.field12 = newField12;
		component.field2 = newField2;
		component.field3 = newField3;
		component.field4 = newField4;
		component.field5 = newField5;
		component.field6 = newField6;
		component.field7 = newField7;
		component.field8 = newField8;
		component.field9 = newField9;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceManyMembers(string newField1, string newField10, string newField11, string newField12, string newField2, string newField3, string newField4, string newField5, string newField6, string newField7, string newField8, string newField9)
	{
		var index = VisualDebugComponentsLookup.ManyMembers;
		var component = (ExampleContent.VisualDebugging.ManyMembersComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.ManyMembersComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.field1 = newField1;
		component.field10 = newField10;
		component.field11 = newField11;
		component.field12 = newField12;
		component.field2 = newField2;
		component.field3 = newField3;
		component.field4 = newField4;
		component.field5 = newField5;
		component.field6 = newField6;
		component.field7 = newField7;
		component.field8 = newField8;
		component.field9 = newField9;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyManyMembersTo(ExampleContent.VisualDebugging.ManyMembersComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.ManyMembers;
		var component = (ExampleContent.VisualDebugging.ManyMembersComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.ManyMembersComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.field1 = copyComponent.field1;
		component.field10 = copyComponent.field10;
		component.field11 = copyComponent.field11;
		component.field12 = copyComponent.field12;
		component.field2 = copyComponent.field2;
		component.field3 = copyComponent.field3;
		component.field4 = copyComponent.field4;
		component.field5 = copyComponent.field5;
		component.field6 = copyComponent.field6;
		component.field7 = copyComponent.field7;
		component.field8 = copyComponent.field8;
		component.field9 = copyComponent.field9;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveManyMembers()
	{
		RemoveComponent(VisualDebugComponentsLookup.ManyMembers);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherManyMembers;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> ManyMembers
	{
		get
		{
			if (_matcherManyMembers == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.ManyMembers);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherManyMembers = matcher;
			}

			return _matcherManyMembers;
		}
	}
}
