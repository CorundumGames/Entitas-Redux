public sealed partial class Test2Context : JCMG.EntitasRedux.Context<Test2Entity>
{
	public Test2Context()
		: base(
			Test2ComponentsLookup.TotalComponents,
			0,
			new JCMG.EntitasRedux.ContextInfo(
				"Test2",
				Test2ComponentsLookup.ComponentNames,
				Test2ComponentsLookup.ComponentTypes
			),
			(entity) =>

#if (ENTITAS_FAST_AND_UNSAFE)
				new JCMG.EntitasRedux.UnsafeAERC(),
#else
				new JCMG.EntitasRedux.SafeAERC(entity),
#endif
			() => new Test2Entity()
		)
	{
	}

	/// <summary>
	/// Creates a new entity and adds copies of all specified components to it. If replaceExisting is true, it will
	/// replace existing components.
	/// </summary>
	public Test2Entity CloneEntity(Test2Entity entity, bool replaceExisting = false, params int[] indices)
	{
		var target = CreateEntity();
		entity.CopyTo(target, replaceExisting, indices);
		return target;
	}
}
