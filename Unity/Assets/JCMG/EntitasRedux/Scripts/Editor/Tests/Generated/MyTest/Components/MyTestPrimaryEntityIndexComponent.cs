//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MyTestEntity {

    public EntitasRedux.Tests.PrimaryEntityIndexComponent PrimaryEntityIndex { get { return (EntitasRedux.Tests.PrimaryEntityIndexComponent)GetComponent(MyTestComponentsLookup.PrimaryEntityIndex); } }
    public bool HasPrimaryEntityIndex { get { return HasComponent(MyTestComponentsLookup.PrimaryEntityIndex); } }

    public void AddPrimaryEntityIndex(string newValue) {
        var index = MyTestComponentsLookup.PrimaryEntityIndex;
        var component = (EntitasRedux.Tests.PrimaryEntityIndexComponent)CreateComponent(index, typeof(EntitasRedux.Tests.PrimaryEntityIndexComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePrimaryEntityIndex(string newValue) {
        var index = MyTestComponentsLookup.PrimaryEntityIndex;
        var component = (EntitasRedux.Tests.PrimaryEntityIndexComponent)CreateComponent(index, typeof(EntitasRedux.Tests.PrimaryEntityIndexComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

	public void CopyPrimaryEntityIndexTo(EntitasRedux.Tests.PrimaryEntityIndexComponent copyComponent) {
        var index = MyTestComponentsLookup.PrimaryEntityIndex;
        var component = (EntitasRedux.Tests.PrimaryEntityIndexComponent)CreateComponent(index, typeof(EntitasRedux.Tests.PrimaryEntityIndexComponent));
        component.value = copyComponent.value;
        ReplaceComponent(index, component);
    }

    public void RemovePrimaryEntityIndex() {
        RemoveComponent(MyTestComponentsLookup.PrimaryEntityIndex);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class MyTestMatcher {

    static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherPrimaryEntityIndex;

    public static JCMG.EntitasRedux.IMatcher<MyTestEntity> PrimaryEntityIndex {
        get {
            if (_matcherPrimaryEntityIndex == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.PrimaryEntityIndex);
                matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
                _matcherPrimaryEntityIndex = matcher;
            }

            return _matcherPrimaryEntityIndex;
        }
    }
}
