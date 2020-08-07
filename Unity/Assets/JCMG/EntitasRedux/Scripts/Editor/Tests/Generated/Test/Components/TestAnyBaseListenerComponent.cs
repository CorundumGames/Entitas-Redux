//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public AnyBaseListenerComponent AnyBaseListener { get { return (AnyBaseListenerComponent)GetComponent(TestComponentsLookup.AnyBaseListener); } }
    public bool HasAnyBaseListener { get { return HasComponent(TestComponentsLookup.AnyBaseListener); } }

    public void AddAnyBaseListener(System.Collections.Generic.List<IAnyBaseListener> newValue) {
        var index = TestComponentsLookup.AnyBaseListener;
        var component = (AnyBaseListenerComponent)CreateComponent(index, typeof(AnyBaseListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyBaseListener(System.Collections.Generic.List<IAnyBaseListener> newValue) {
        var index = TestComponentsLookup.AnyBaseListener;
        var component = (AnyBaseListenerComponent)CreateComponent(index, typeof(AnyBaseListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyBaseListener() {
        RemoveComponent(TestComponentsLookup.AnyBaseListener);
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
public sealed partial class TestMatcher {

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherAnyBaseListener;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> AnyBaseListener {
        get {
            if (_matcherAnyBaseListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.AnyBaseListener);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherAnyBaseListener = matcher;
            }

            return _matcherAnyBaseListener;
        }
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
public partial class TestEntity {

    public void AddAnyBaseListener(IAnyBaseListener value) {
        var listeners = HasAnyBaseListener
            ? AnyBaseListener.value
            : new System.Collections.Generic.List<IAnyBaseListener>();
        listeners.Add(value);
        ReplaceAnyBaseListener(listeners);
    }

    public void RemoveAnyBaseListener(IAnyBaseListener value, bool removeComponentWhenEmpty = true) {
        var listeners = AnyBaseListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyBaseListener();
        } else {
            ReplaceAnyBaseListener(listeners);
        }
    }
}
