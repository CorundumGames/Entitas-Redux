//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class MyTestContext : JCMG.EntitasRedux.Context<MyTestEntity> {

    public MyTestContext()
        : base(
            MyTestComponentsLookup.TotalComponents,
            0,
            new JCMG.EntitasRedux.ContextInfo(
                "MyTest",
                MyTestComponentsLookup.ComponentNames,
                MyTestComponentsLookup.ComponentTypes
            ),
            (entity) =>

#if (ENTITAS_FAST_AND_UNSAFE)
                new JCMG.EntitasRedux.UnsafeAERC(),
#else
                new JCMG.EntitasRedux.SafeAERC(entity),
#endif
            () => new MyTestEntity()
        ) {
    }
}
