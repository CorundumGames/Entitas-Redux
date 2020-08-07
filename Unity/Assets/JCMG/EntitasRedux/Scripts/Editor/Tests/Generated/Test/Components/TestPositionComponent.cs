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

    public EntitasRedux.Tests.PositionComponent Position { get { return (EntitasRedux.Tests.PositionComponent)GetComponent(TestComponentsLookup.Position); } }
    public bool HasPosition { get { return HasComponent(TestComponentsLookup.Position); } }

    public void AddPosition(int newX, int newY) {
        var index = TestComponentsLookup.Position;
        var component = (EntitasRedux.Tests.PositionComponent)CreateComponent(index, typeof(EntitasRedux.Tests.PositionComponent));
        component.x = newX;
        component.y = newY;
        AddComponent(index, component);
    }

    public void ReplacePosition(int newX, int newY) {
        var index = TestComponentsLookup.Position;
        var component = (EntitasRedux.Tests.PositionComponent)CreateComponent(index, typeof(EntitasRedux.Tests.PositionComponent));
        component.x = newX;
        component.y = newY;
        ReplaceComponent(index, component);
    }

    public void RemovePosition() {
        RemoveComponent(TestComponentsLookup.Position);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherPosition;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> Position {
        get {
            if (_matcherPosition == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.Position);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherPosition = matcher;
            }

            return _matcherPosition;
        }
    }
}
