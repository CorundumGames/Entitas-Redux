//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public EntitasRedux.Tests.Test2ContextComponent Test2Context { get { return (EntitasRedux.Tests.Test2ContextComponent)GetComponent(TestComponentsLookup.Test2Context); } }
    public bool hasTest2Context { get { return HasComponent(TestComponentsLookup.Test2Context); } }

    public void AddTest2Context(string newValue) {
        var index = TestComponentsLookup.Test2Context;
        var component = (EntitasRedux.Tests.Test2ContextComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Test2ContextComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTest2Context(string newValue) {
        var index = TestComponentsLookup.Test2Context;
        var component = (EntitasRedux.Tests.Test2ContextComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Test2ContextComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTest2Context() {
        RemoveComponent(TestComponentsLookup.Test2Context);
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
public partial class TestEntity : ITest2ContextEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherTest2Context;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> Test2Context {
        get {
            if (_matcherTest2Context == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.Test2Context);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherTest2Context = matcher;
            }

            return _matcherTest2Context;
        }
    }
}
