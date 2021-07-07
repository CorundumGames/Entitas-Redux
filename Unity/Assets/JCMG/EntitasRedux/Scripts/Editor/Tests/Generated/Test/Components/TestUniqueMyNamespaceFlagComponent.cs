public partial class TestContext
{
	public TestEntity UniqueMyNamespaceFlagEntity { get { return GetGroup(TestMatcher.UniqueMyNamespaceFlag).GetSingleEntity(); } }

	public bool IsUniqueMyNamespaceFlag
	{
		get { return UniqueMyNamespaceFlagEntity != null; }
		set
		{
			var entity = UniqueMyNamespaceFlagEntity;
			if (value != (entity != null))
			{
				if (value)
				{
					CreateEntity().IsUniqueMyNamespaceFlag = true;
				}
				else
				{
					entity.Destroy();
				}
			}
		}
	}
}

public partial class TestEntity
{
	static readonly EntitasRedux.Tests.UniqueMyNamespaceFlagComponent UniqueMyNamespaceFlagComponent = new EntitasRedux.Tests.UniqueMyNamespaceFlagComponent();

	public bool IsUniqueMyNamespaceFlag
	{
		get { return HasComponent(TestComponentsLookup.UniqueMyNamespaceFlag); }
		set
		{
			if (value != IsUniqueMyNamespaceFlag)
			{
				var index = TestComponentsLookup.UniqueMyNamespaceFlag;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: UniqueMyNamespaceFlagComponent;

					AddComponent(index, component);
				}
				else
				{
					RemoveComponent(index);
				}
			}
		}
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherUniqueMyNamespaceFlag;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> UniqueMyNamespaceFlag
	{
		get
		{
			if (_matcherUniqueMyNamespaceFlag == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.UniqueMyNamespaceFlag);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherUniqueMyNamespaceFlag = matcher;
			}

			return _matcherUniqueMyNamespaceFlag;
		}
	}
}
