//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MyTestEntity {

    public EntitasRedux.Tests.Array3dComponent Array3d { get { return (EntitasRedux.Tests.Array3dComponent)GetComponent(MyTestComponentsLookup.Array3d); } }
    public bool HasArray3d { get { return HasComponent(MyTestComponentsLookup.Array3d); } }

    public void AddArray3d(int[,,] newValue) {
        var index = MyTestComponentsLookup.Array3d;
        var component = (EntitasRedux.Tests.Array3dComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Array3dComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceArray3d(int[,,] newValue) {
        var index = MyTestComponentsLookup.Array3d;
        var component = (EntitasRedux.Tests.Array3dComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Array3dComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

	public void CopyArray3dTo(EntitasRedux.Tests.Array3dComponent copyComponent) {
        var index = MyTestComponentsLookup.Array3d;
        var component = (EntitasRedux.Tests.Array3dComponent)CreateComponent(index, typeof(EntitasRedux.Tests.Array3dComponent));
        component.value = (int[,,])copyComponent.value.Clone();
        ReplaceComponent(index, component);
    }

    public void RemoveArray3d() {
        RemoveComponent(MyTestComponentsLookup.Array3d);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class MyTestMatcher {

    static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherArray3d;

    public static JCMG.EntitasRedux.IMatcher<MyTestEntity> Array3d {
        get {
            if (_matcherArray3d == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.Array3d);
                matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
                _matcherArray3d = matcher;
            }

            return _matcherArray3d;
        }
    }
}
