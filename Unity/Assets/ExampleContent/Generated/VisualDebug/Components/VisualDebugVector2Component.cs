//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public ExampleContent.VisualDebugging.Vector2Component Vector2 { get { return (ExampleContent.VisualDebugging.Vector2Component)GetComponent(VisualDebugComponentsLookup.Vector2); } }
    public bool HasVector2 { get { return HasComponent(VisualDebugComponentsLookup.Vector2); } }

    public void AddVector2(UnityEngine.Vector2 newVector2) {
        var index = VisualDebugComponentsLookup.Vector2;
        var component = (ExampleContent.VisualDebugging.Vector2Component)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Vector2Component));
        component.vector2 = newVector2;
        AddComponent(index, component);
    }

    public void ReplaceVector2(UnityEngine.Vector2 newVector2) {
        var index = VisualDebugComponentsLookup.Vector2;
        var component = (ExampleContent.VisualDebugging.Vector2Component)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Vector2Component));
        component.vector2 = newVector2;
        ReplaceComponent(index, component);
    }

    public void RemoveVector2() {
        RemoveComponent(VisualDebugComponentsLookup.Vector2);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherVector2;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Vector2 {
        get {
            if (_matcherVector2 == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Vector2);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherVector2 = matcher;
            }

            return _matcherVector2;
        }
    }
}
