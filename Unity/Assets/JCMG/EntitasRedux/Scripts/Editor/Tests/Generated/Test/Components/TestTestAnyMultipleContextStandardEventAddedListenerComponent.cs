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

    public TestAnyMultipleContextStandardEventAddedListenerComponent TestAnyMultipleContextStandardEventAddedListener { get { return (TestAnyMultipleContextStandardEventAddedListenerComponent)GetComponent(TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener); } }
    public bool HasTestAnyMultipleContextStandardEventAddedListener { get { return HasComponent(TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener); } }

    public void AddTestAnyMultipleContextStandardEventAddedListener(System.Collections.Generic.List<ITestAnyMultipleContextStandardEventAddedListener> newValue) {
        var index = TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener;
        var component = (TestAnyMultipleContextStandardEventAddedListenerComponent)CreateComponent(index, typeof(TestAnyMultipleContextStandardEventAddedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTestAnyMultipleContextStandardEventAddedListener(System.Collections.Generic.List<ITestAnyMultipleContextStandardEventAddedListener> newValue) {
        var index = TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener;
        var component = (TestAnyMultipleContextStandardEventAddedListenerComponent)CreateComponent(index, typeof(TestAnyMultipleContextStandardEventAddedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

	public void CopyTestAnyMultipleContextStandardEventAddedListenerTo(TestAnyMultipleContextStandardEventAddedListenerComponent copyComponent) {
        var index = TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener;
        var component = (TestAnyMultipleContextStandardEventAddedListenerComponent)CreateComponent(index, typeof(TestAnyMultipleContextStandardEventAddedListenerComponent));
        component.value = copyComponent.value;
        ReplaceComponent(index, component);
    }

    public void RemoveTestAnyMultipleContextStandardEventAddedListener() {
        RemoveComponent(TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherTestAnyMultipleContextStandardEventAddedListener;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> TestAnyMultipleContextStandardEventAddedListener {
        get {
            if (_matcherTestAnyMultipleContextStandardEventAddedListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.TestAnyMultipleContextStandardEventAddedListener);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherTestAnyMultipleContextStandardEventAddedListener = matcher;
            }

            return _matcherTestAnyMultipleContextStandardEventAddedListener;
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

    public void AddTestAnyMultipleContextStandardEventAddedListener(ITestAnyMultipleContextStandardEventAddedListener value) {
        var listeners = HasTestAnyMultipleContextStandardEventAddedListener
            ? TestAnyMultipleContextStandardEventAddedListener.value
            : new System.Collections.Generic.List<ITestAnyMultipleContextStandardEventAddedListener>();
        listeners.Add(value);
        ReplaceTestAnyMultipleContextStandardEventAddedListener(listeners);
    }

    public void RemoveTestAnyMultipleContextStandardEventAddedListener(ITestAnyMultipleContextStandardEventAddedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = TestAnyMultipleContextStandardEventAddedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTestAnyMultipleContextStandardEventAddedListener();
        } else {
            ReplaceTestAnyMultipleContextStandardEventAddedListener(listeners);
        }
    }
}
