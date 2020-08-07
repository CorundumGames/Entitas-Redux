//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestContext {

    public TestEntity UniqueFlagEntity { get { return GetGroup(TestMatcher.UniqueFlag).GetSingleEntity(); } }

    public bool IsUniqueFlag {
        get { return UniqueFlagEntity != null; }
        set {
            var entity = UniqueFlagEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().IsUniqueFlag = true;
                } else {
                    entity.Destroy();
                }
            }
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

    static readonly EntitasRedux.Tests.UniqueFlagComponent UniqueFlagComponent = new EntitasRedux.Tests.UniqueFlagComponent();

    public bool IsUniqueFlag {
        get { return HasComponent(TestComponentsLookup.UniqueFlag); }
        set {
            if (value != IsUniqueFlag) {
                var index = TestComponentsLookup.UniqueFlag;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : UniqueFlagComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
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
public sealed partial class TestMatcher {

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherUniqueFlag;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> UniqueFlag {
        get {
            if (_matcherUniqueFlag == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.UniqueFlag);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherUniqueFlag = matcher;
            }

            return _matcherUniqueFlag;
        }
    }
}
