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

    public TestAnyMultipleContextStandardEventListenerComponent TestAnyMultipleContextStandardEventListener { get { return (TestAnyMultipleContextStandardEventListenerComponent)GetComponent(TestComponentsLookup.TestAnyMultipleContextStandardEventListener); } }
    public bool HasTestAnyMultipleContextStandardEventListener { get { return HasComponent(TestComponentsLookup.TestAnyMultipleContextStandardEventListener); } }

    public void AddTestAnyMultipleContextStandardEventListener(System.Collections.Generic.List<ITestAnyMultipleContextStandardEventListener> newValue) {
        var index = TestComponentsLookup.TestAnyMultipleContextStandardEventListener;
        var component = (TestAnyMultipleContextStandardEventListenerComponent)CreateComponent(index, typeof(TestAnyMultipleContextStandardEventListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTestAnyMultipleContextStandardEventListener(System.Collections.Generic.List<ITestAnyMultipleContextStandardEventListener> newValue) {
        var index = TestComponentsLookup.TestAnyMultipleContextStandardEventListener;
        var component = (TestAnyMultipleContextStandardEventListenerComponent)CreateComponent(index, typeof(TestAnyMultipleContextStandardEventListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTestAnyMultipleContextStandardEventListener() {
        RemoveComponent(TestComponentsLookup.TestAnyMultipleContextStandardEventListener);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherTestAnyMultipleContextStandardEventListener;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> TestAnyMultipleContextStandardEventListener {
        get {
            if (_matcherTestAnyMultipleContextStandardEventListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.TestAnyMultipleContextStandardEventListener);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherTestAnyMultipleContextStandardEventListener = matcher;
            }

            return _matcherTestAnyMultipleContextStandardEventListener;
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

    public void AddTestAnyMultipleContextStandardEventListener(ITestAnyMultipleContextStandardEventListener value) {
        var listeners = HasTestAnyMultipleContextStandardEventListener
            ? TestAnyMultipleContextStandardEventListener.value
            : new System.Collections.Generic.List<ITestAnyMultipleContextStandardEventListener>();
        listeners.Add(value);
        ReplaceTestAnyMultipleContextStandardEventListener(listeners);
    }

    public void RemoveTestAnyMultipleContextStandardEventListener(ITestAnyMultipleContextStandardEventListener value, bool removeComponentWhenEmpty = true) {
        var listeners = TestAnyMultipleContextStandardEventListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTestAnyMultipleContextStandardEventListener();
        } else {
            ReplaceTestAnyMultipleContextStandardEventListener(listeners);
        }
    }
}
