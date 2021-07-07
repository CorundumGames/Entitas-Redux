public partial class Test2Context {

	public Test2Entity UniqueClassToGenerateEntity { get { return GetGroup(Test2Matcher.UniqueClassToGenerate).GetSingleEntity(); } }
	public UniqueClassToGenerateComponent UniqueClassToGenerate { get { return UniqueClassToGenerateEntity.UniqueClassToGenerate; } }
	public bool HasUniqueClassToGenerate { get { return UniqueClassToGenerateEntity != null; } }

	public Test2Entity SetUniqueClassToGenerate(EntitasRedux.Tests.UniqueClassToGenerate newValue)
	{
		if (HasUniqueClassToGenerate)
		{
			throw new JCMG.EntitasRedux.EntitasReduxException(
				"Could not set UniqueClassToGenerate!\n" +
				this +
				" already has an entity with UniqueClassToGenerateComponent!",
				"You should check if the context already has a UniqueClassToGenerateEntity before setting it or use context.ReplaceUniqueClassToGenerate().");
		}
		var entity = CreateEntity();
		#if !ENTITAS_REDUX_NO_IMPL
		entity.AddUniqueClassToGenerate(newValue);
		#endif
		return entity;
	}

	public void ReplaceUniqueClassToGenerate(EntitasRedux.Tests.UniqueClassToGenerate newValue)
	{
		#if !ENTITAS_REDUX_NO_IMPL
		var entity = UniqueClassToGenerateEntity;
		if (entity == null)
		{
			entity = SetUniqueClassToGenerate(newValue);
		}
		else
		{
			entity.ReplaceUniqueClassToGenerate(newValue);
		}
		#endif
	}

	public void RemoveUniqueClassToGenerate()
	{
		UniqueClassToGenerateEntity.Destroy();
	}
}

public partial class Test2Entity
{
	public UniqueClassToGenerateComponent UniqueClassToGenerate { get { return (UniqueClassToGenerateComponent)GetComponent(Test2ComponentsLookup.UniqueClassToGenerate); } }
	public bool HasUniqueClassToGenerate { get { return HasComponent(Test2ComponentsLookup.UniqueClassToGenerate); } }

	public void AddUniqueClassToGenerate(EntitasRedux.Tests.UniqueClassToGenerate newValue)
	{
		var index = Test2ComponentsLookup.UniqueClassToGenerate;
		var component = (UniqueClassToGenerateComponent)CreateComponent(index, typeof(UniqueClassToGenerateComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceUniqueClassToGenerate(EntitasRedux.Tests.UniqueClassToGenerate newValue)
	{
		var index = Test2ComponentsLookup.UniqueClassToGenerate;
		var component = (UniqueClassToGenerateComponent)CreateComponent(index, typeof(UniqueClassToGenerateComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyUniqueClassToGenerateTo(UniqueClassToGenerateComponent copyComponent)
	{
		var index = Test2ComponentsLookup.UniqueClassToGenerate;
		var component = (UniqueClassToGenerateComponent)CreateComponent(index, typeof(UniqueClassToGenerateComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveUniqueClassToGenerate()
	{
		RemoveComponent(Test2ComponentsLookup.UniqueClassToGenerate);
	}
}

public partial class Test2Entity : IUniqueClassToGenerateEntity { }

public sealed partial class Test2Matcher
{
	static JCMG.EntitasRedux.IMatcher<Test2Entity> _matcherUniqueClassToGenerate;

	public static JCMG.EntitasRedux.IMatcher<Test2Entity> UniqueClassToGenerate
	{
		get
		{
			if (_matcherUniqueClassToGenerate == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<Test2Entity>)JCMG.EntitasRedux.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.UniqueClassToGenerate);
				matcher.ComponentNames = Test2ComponentsLookup.ComponentNames;
				_matcherUniqueClassToGenerate = matcher;
			}

			return _matcherUniqueClassToGenerate;
		}
	}
}
