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

    public ExampleContent.VisualDebugging.Vector4Component Vector4 { get { return (ExampleContent.VisualDebugging.Vector4Component)GetComponent(VisualDebugComponentsLookup.Vector4); } }
    public bool HasVector4 { get { return HasComponent(VisualDebugComponentsLookup.Vector4); } }

    public void AddVector4(UnityEngine.Vector4 newVector4) {
        var index = VisualDebugComponentsLookup.Vector4;
        var component = (ExampleContent.VisualDebugging.Vector4Component)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Vector4Component));
        component.vector4 = newVector4;
        AddComponent(index, component);
    }

    public void ReplaceVector4(UnityEngine.Vector4 newVector4) {
        var index = VisualDebugComponentsLookup.Vector4;
        var component = (ExampleContent.VisualDebugging.Vector4Component)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Vector4Component));
        component.vector4 = newVector4;
        ReplaceComponent(index, component);
    }

    public void RemoveVector4() {
        RemoveComponent(VisualDebugComponentsLookup.Vector4);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherVector4;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Vector4 {
        get {
            if (_matcherVector4 == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Vector4);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherVector4 = matcher;
            }

            return _matcherVector4;
        }
    }
}
