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

    public static JCMG.EntitasRedux.IAllOfMatcher<TestEntity> AllOf(params int[] indices) {
        return JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(indices);
    }

    public static JCMG.EntitasRedux.IAllOfMatcher<TestEntity> AllOf(params JCMG.EntitasRedux.IMatcher<TestEntity>[] matchers) {
          return JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(matchers);
    }

    public static JCMG.EntitasRedux.IAnyOfMatcher<TestEntity> AnyOf(params int[] indices) {
          return JCMG.EntitasRedux.Matcher<TestEntity>.AnyOf(indices);
    }

    public static JCMG.EntitasRedux.IAnyOfMatcher<TestEntity> AnyOf(params JCMG.EntitasRedux.IMatcher<TestEntity>[] matchers) {
          return JCMG.EntitasRedux.Matcher<TestEntity>.AnyOf(matchers);
    }
}
