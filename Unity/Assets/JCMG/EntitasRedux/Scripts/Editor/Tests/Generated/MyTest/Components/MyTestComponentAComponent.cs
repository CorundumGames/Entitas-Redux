//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MyTestEntity {

    static readonly EntitasRedux.Tests.ComponentA ComponentAComponent = new EntitasRedux.Tests.ComponentA();

    public bool IsComponentA {
        get { return HasComponent(MyTestComponentsLookup.ComponentA); }
        set {
            if (value != IsComponentA) {
                var index = MyTestComponentsLookup.ComponentA;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : ComponentAComponent;

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
public sealed partial class MyTestMatcher {

    static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherComponentA;

    public static JCMG.EntitasRedux.IMatcher<MyTestEntity> ComponentA {
        get {
            if (_matcherComponentA == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.ComponentA);
                matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
                _matcherComponentA = matcher;
            }

            return _matcherComponentA;
        }
    }
}
