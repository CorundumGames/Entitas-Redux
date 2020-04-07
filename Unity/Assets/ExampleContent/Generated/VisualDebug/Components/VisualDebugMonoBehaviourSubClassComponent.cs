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

    public ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent MonoBehaviourSubClass { get { return (ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent)GetComponent(VisualDebugComponentsLookup.MonoBehaviourSubClass); } }
    public bool hasMonoBehaviourSubClass { get { return HasComponent(VisualDebugComponentsLookup.MonoBehaviourSubClass); } }

    public void AddMonoBehaviourSubClass(ExampleContent.VisualDebugging.MonoBehaviourSubClass newMonoBehaviour) {
        var index = VisualDebugComponentsLookup.MonoBehaviourSubClass;
        var component = (ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent));
        component.monoBehaviour = newMonoBehaviour;
        AddComponent(index, component);
    }

    public void ReplaceMonoBehaviourSubClass(ExampleContent.VisualDebugging.MonoBehaviourSubClass newMonoBehaviour) {
        var index = VisualDebugComponentsLookup.MonoBehaviourSubClass;
        var component = (ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent));
        component.monoBehaviour = newMonoBehaviour;
        ReplaceComponent(index, component);
    }

    public void RemoveMonoBehaviourSubClass() {
        RemoveComponent(VisualDebugComponentsLookup.MonoBehaviourSubClass);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMonoBehaviourSubClass;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MonoBehaviourSubClass {
        get {
            if (_matcherMonoBehaviourSubClass == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MonoBehaviourSubClass);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherMonoBehaviourSubClass = matcher;
            }

            return _matcherMonoBehaviourSubClass;
        }
    }
}
