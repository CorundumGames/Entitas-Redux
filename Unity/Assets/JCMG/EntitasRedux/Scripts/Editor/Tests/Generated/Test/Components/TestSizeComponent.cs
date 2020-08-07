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

    public EntitasRedux.Tests.SizeComponent Size { get { return (EntitasRedux.Tests.SizeComponent)GetComponent(TestComponentsLookup.Size); } }
    public bool HasSize { get { return HasComponent(TestComponentsLookup.Size); } }

    public void AddSize(int newWidth, int newHeight) {
        var index = TestComponentsLookup.Size;
        var component = (EntitasRedux.Tests.SizeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.SizeComponent));
        component.width = newWidth;
        component.height = newHeight;
        AddComponent(index, component);
    }

    public void ReplaceSize(int newWidth, int newHeight) {
        var index = TestComponentsLookup.Size;
        var component = (EntitasRedux.Tests.SizeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.SizeComponent));
        component.width = newWidth;
        component.height = newHeight;
        ReplaceComponent(index, component);
    }

    public void RemoveSize() {
        RemoveComponent(TestComponentsLookup.Size);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherSize;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> Size {
        get {
            if (_matcherSize == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.Size);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherSize = matcher;
            }

            return _matcherSize;
        }
    }
}
