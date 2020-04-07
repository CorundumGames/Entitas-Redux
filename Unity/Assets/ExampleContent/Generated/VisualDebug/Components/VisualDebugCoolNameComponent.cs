//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public CoolNameComponent CoolName { get { return (CoolNameComponent)GetComponent(VisualDebugComponentsLookup.CoolName); } }
    public bool hasCoolName { get { return HasComponent(VisualDebugComponentsLookup.CoolName); } }

    public void AddCoolName(ExampleContent.VisualDebugging.BadName newValue) {
        var index = VisualDebugComponentsLookup.CoolName;
        var component = (CoolNameComponent)CreateComponent(index, typeof(CoolNameComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCoolName(ExampleContent.VisualDebugging.BadName newValue) {
        var index = VisualDebugComponentsLookup.CoolName;
        var component = (CoolNameComponent)CreateComponent(index, typeof(CoolNameComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCoolName() {
        RemoveComponent(VisualDebugComponentsLookup.CoolName);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherCoolName;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> CoolName {
        get {
            if (_matcherCoolName == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.CoolName);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherCoolName = matcher;
            }

            return _matcherCoolName;
        }
    }
}
