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

    public TestAnyEventToGenerateListenerComponent TestAnyEventToGenerateListener { get { return (TestAnyEventToGenerateListenerComponent)GetComponent(TestComponentsLookup.TestAnyEventToGenerateListener); } }
    public bool HasTestAnyEventToGenerateListener { get { return HasComponent(TestComponentsLookup.TestAnyEventToGenerateListener); } }

    public void AddTestAnyEventToGenerateListener(System.Collections.Generic.List<ITestAnyEventToGenerateListener> newValue) {
        var index = TestComponentsLookup.TestAnyEventToGenerateListener;
        var component = (TestAnyEventToGenerateListenerComponent)CreateComponent(index, typeof(TestAnyEventToGenerateListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTestAnyEventToGenerateListener(System.Collections.Generic.List<ITestAnyEventToGenerateListener> newValue) {
        var index = TestComponentsLookup.TestAnyEventToGenerateListener;
        var component = (TestAnyEventToGenerateListenerComponent)CreateComponent(index, typeof(TestAnyEventToGenerateListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

	public void CopyTestAnyEventToGenerateListenerTo(TestAnyEventToGenerateListenerComponent copyComponent) {
        var index = TestComponentsLookup.TestAnyEventToGenerateListener;
        var component = (TestAnyEventToGenerateListenerComponent)CreateComponent(index, typeof(TestAnyEventToGenerateListenerComponent));
        component.value = copyComponent.value;
        ReplaceComponent(index, component);
    }

    public void RemoveTestAnyEventToGenerateListener() {
        RemoveComponent(TestComponentsLookup.TestAnyEventToGenerateListener);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherTestAnyEventToGenerateListener;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> TestAnyEventToGenerateListener {
        get {
            if (_matcherTestAnyEventToGenerateListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.TestAnyEventToGenerateListener);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherTestAnyEventToGenerateListener = matcher;
            }

            return _matcherTestAnyEventToGenerateListener;
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

    public void AddTestAnyEventToGenerateListener(ITestAnyEventToGenerateListener value) {
        var listeners = HasTestAnyEventToGenerateListener
            ? TestAnyEventToGenerateListener.value
            : new System.Collections.Generic.List<ITestAnyEventToGenerateListener>();
        listeners.Add(value);
        ReplaceTestAnyEventToGenerateListener(listeners);
    }

    public void RemoveTestAnyEventToGenerateListener(ITestAnyEventToGenerateListener value, bool removeComponentWhenEmpty = true) {
        var listeners = TestAnyEventToGenerateListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTestAnyEventToGenerateListener();
        } else {
            ReplaceTestAnyEventToGenerateListener(listeners);
        }
    }
}
