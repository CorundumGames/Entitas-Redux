//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestContext : JCMG.EntitasRedux.Context<TestEntity> {

    public TestContext()
        : base(
            TestComponentsLookup.TotalComponents,
            0,
            new JCMG.EntitasRedux.ContextInfo(
                "Test",
                TestComponentsLookup.ComponentNames,
                TestComponentsLookup.ComponentTypes
            ),
            (entity) =>

#if (ENTITAS_FAST_AND_UNSAFE)
                new JCMG.EntitasRedux.UnsafeAERC(),
#else
                new JCMG.EntitasRedux.SafeAERC(entity),
#endif
            () => new TestEntity()
        ) {
    }
}
