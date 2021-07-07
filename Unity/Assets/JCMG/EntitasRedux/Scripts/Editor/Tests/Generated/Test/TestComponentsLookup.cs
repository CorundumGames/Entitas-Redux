using System;
using System.Collections.Generic;
using JCMG.EntitasRedux;

public static class TestComponentsLookup
{
	public const int AnyBaseAddedListener = 0;
	public const int AnyFlagEventRemovedListener = 1;
	public const int AnyMixedEventAddedListener = 2;
	public const int AnyStandardEventAddedListener = 3;
	public const int AnyUniqueEventAddedListener = 4;
	public const int ClassToGenerate = 5;
	public const int ClassWithEntitIndexAttribute = 6;
	public const int Base = 7;
	public const int ComponentWithFields = 8;
	public const int ComponentWithFieldsAndProperties = 9;
	public const int ComponentWithProperties = 10;
	public const int CustomPrefixFlag = 11;
	public const int EntityIndex = 12;
	public const int Flag = 13;
	public const int FlagEntityEvent = 14;
	public const int FlagEvent = 15;
	public const int MixedEvent = 16;
	public const int MultipleContextStandardEvent = 17;
	public const int MultipleEntityIndices = 18;
	public const int MultipleEventsStandardEvent = 19;
	public const int MyNamespace = 20;
	public const int MyNamespaceFlag = 21;
	public const int NameAge = 22;
	public const int Position = 23;
	public const int Size = 24;
	public const int Standard = 25;
	public const int StandardEntityEvent = 26;
	public const int StandardEvent = 27;
	public const int Test2Context = 28;
	public const int UniqueEvent = 29;
	public const int UniqueFlag = 30;
	public const int UniqueMyNamespace = 31;
	public const int UniqueMyNamespaceFlag = 32;
	public const int UniqueStandard = 33;
	public const int EventToGenerate = 34;
	public const int FlagEntityEventAddedListener = 35;
	public const int InterfaceToGenerate = 36;
	public const int MixedEventAddedListener = 37;
	public const int NewCustomNameComponent1 = 38;
	public const int NewCustomNameComponent2 = 39;
	public const int StandardEntityEventRemovedListener = 40;
	public const int StructToGenerate = 41;
	public const int TestAnyEventToGenerateAddedListener = 42;
	public const int TestAnyMultipleContextStandardEventAddedListener = 43;
	public const int TestAnyMultipleEventsStandardEventAddedListener = 44;
	public const int TestMultipleEventsStandardEventRemovedListener = 45;
	public const int UniqueClassToGenerate = 46;

	public const int TotalComponents = 47;

	public static readonly string[] ComponentNames =
	{
		"AnyBaseAddedListener",
		"AnyFlagEventRemovedListener",
		"AnyMixedEventAddedListener",
		"AnyStandardEventAddedListener",
		"AnyUniqueEventAddedListener",
		"ClassToGenerate",
		"ClassWithEntitIndexAttribute",
		"Base",
		"ComponentWithFields",
		"ComponentWithFieldsAndProperties",
		"ComponentWithProperties",
		"CustomPrefixFlag",
		"EntityIndex",
		"Flag",
		"FlagEntityEvent",
		"FlagEvent",
		"MixedEvent",
		"MultipleContextStandardEvent",
		"MultipleEntityIndices",
		"MultipleEventsStandardEvent",
		"MyNamespace",
		"MyNamespaceFlag",
		"NameAge",
		"Position",
		"Size",
		"Standard",
		"StandardEntityEvent",
		"StandardEvent",
		"Test2Context",
		"UniqueEvent",
		"UniqueFlag",
		"UniqueMyNamespace",
		"UniqueMyNamespaceFlag",
		"UniqueStandard",
		"EventToGenerate",
		"FlagEntityEventAddedListener",
		"InterfaceToGenerate",
		"MixedEventAddedListener",
		"NewCustomNameComponent1",
		"NewCustomNameComponent2",
		"StandardEntityEventRemovedListener",
		"StructToGenerate",
		"TestAnyEventToGenerateAddedListener",
		"TestAnyMultipleContextStandardEventAddedListener",
		"TestAnyMultipleEventsStandardEventAddedListener",
		"TestMultipleEventsStandardEventRemovedListener",
		"UniqueClassToGenerate"
	};

	public static readonly System.Type[] ComponentTypes =
	{
		typeof(AnyBaseAddedListenerComponent),
		typeof(AnyFlagEventRemovedListenerComponent),
		typeof(AnyMixedEventAddedListenerComponent),
		typeof(AnyStandardEventAddedListenerComponent),
		typeof(AnyUniqueEventAddedListenerComponent),
		typeof(ClassToGenerateComponent),
		typeof(ClassWithEntitIndexAttributeComponent),
		typeof(EntitasRedux.Tests.BaseComponent),
		typeof(EntitasRedux.Tests.ComponentWithFields),
		typeof(EntitasRedux.Tests.ComponentWithFieldsAndProperties),
		typeof(EntitasRedux.Tests.ComponentWithProperties),
		typeof(EntitasRedux.Tests.CustomPrefixFlagComponent),
		typeof(EntitasRedux.Tests.EntityIndexComponent),
		typeof(EntitasRedux.Tests.FlagComponent),
		typeof(EntitasRedux.Tests.FlagEntityEventComponent),
		typeof(EntitasRedux.Tests.FlagEventComponent),
		typeof(EntitasRedux.Tests.MixedEventComponent),
		typeof(EntitasRedux.Tests.MultipleContextStandardEventComponent),
		typeof(EntitasRedux.Tests.MultipleEntityIndicesComponent),
		typeof(EntitasRedux.Tests.MultipleEventsStandardEventComponent),
		typeof(EntitasRedux.Tests.MyNamespaceComponent),
		typeof(EntitasRedux.Tests.MyNamespaceFlagComponent),
		typeof(EntitasRedux.Tests.NameAgeComponent),
		typeof(EntitasRedux.Tests.PositionComponent),
		typeof(EntitasRedux.Tests.SizeComponent),
		typeof(EntitasRedux.Tests.StandardComponent),
		typeof(EntitasRedux.Tests.StandardEntityEventComponent),
		typeof(EntitasRedux.Tests.StandardEventComponent),
		typeof(EntitasRedux.Tests.Test2ContextComponent),
		typeof(EntitasRedux.Tests.UniqueEventComponent),
		typeof(EntitasRedux.Tests.UniqueFlagComponent),
		typeof(EntitasRedux.Tests.UniqueMyNamespaceComponent),
		typeof(EntitasRedux.Tests.UniqueMyNamespaceFlagComponent),
		typeof(EntitasRedux.Tests.UniqueStandardComponent),
		typeof(EventToGenerateComponent),
		typeof(FlagEntityEventAddedListenerComponent),
		typeof(InterfaceToGenerateComponent),
		typeof(MixedEventAddedListenerComponent),
		typeof(NewCustomNameComponent1Component),
		typeof(NewCustomNameComponent2Component),
		typeof(StandardEntityEventRemovedListenerComponent),
		typeof(StructToGenerateComponent),
		typeof(TestAnyEventToGenerateAddedListenerComponent),
		typeof(TestAnyMultipleContextStandardEventAddedListenerComponent),
		typeof(TestAnyMultipleEventsStandardEventAddedListenerComponent),
		typeof(TestMultipleEventsStandardEventRemovedListenerComponent),
		typeof(UniqueClassToGenerateComponent)
	};

	public static readonly Dictionary<Type, int> ComponentTypeToIndex = new Dictionary<Type, int>
	{
		{ typeof(AnyBaseAddedListenerComponent), 0 },
		{ typeof(AnyFlagEventRemovedListenerComponent), 1 },
		{ typeof(AnyMixedEventAddedListenerComponent), 2 },
		{ typeof(AnyStandardEventAddedListenerComponent), 3 },
		{ typeof(AnyUniqueEventAddedListenerComponent), 4 },
		{ typeof(ClassToGenerateComponent), 5 },
		{ typeof(ClassWithEntitIndexAttributeComponent), 6 },
		{ typeof(EntitasRedux.Tests.BaseComponent), 7 },
		{ typeof(EntitasRedux.Tests.ComponentWithFields), 8 },
		{ typeof(EntitasRedux.Tests.ComponentWithFieldsAndProperties), 9 },
		{ typeof(EntitasRedux.Tests.ComponentWithProperties), 10 },
		{ typeof(EntitasRedux.Tests.CustomPrefixFlagComponent), 11 },
		{ typeof(EntitasRedux.Tests.EntityIndexComponent), 12 },
		{ typeof(EntitasRedux.Tests.FlagComponent), 13 },
		{ typeof(EntitasRedux.Tests.FlagEntityEventComponent), 14 },
		{ typeof(EntitasRedux.Tests.FlagEventComponent), 15 },
		{ typeof(EntitasRedux.Tests.MixedEventComponent), 16 },
		{ typeof(EntitasRedux.Tests.MultipleContextStandardEventComponent), 17 },
		{ typeof(EntitasRedux.Tests.MultipleEntityIndicesComponent), 18 },
		{ typeof(EntitasRedux.Tests.MultipleEventsStandardEventComponent), 19 },
		{ typeof(EntitasRedux.Tests.MyNamespaceComponent), 20 },
		{ typeof(EntitasRedux.Tests.MyNamespaceFlagComponent), 21 },
		{ typeof(EntitasRedux.Tests.NameAgeComponent), 22 },
		{ typeof(EntitasRedux.Tests.PositionComponent), 23 },
		{ typeof(EntitasRedux.Tests.SizeComponent), 24 },
		{ typeof(EntitasRedux.Tests.StandardComponent), 25 },
		{ typeof(EntitasRedux.Tests.StandardEntityEventComponent), 26 },
		{ typeof(EntitasRedux.Tests.StandardEventComponent), 27 },
		{ typeof(EntitasRedux.Tests.Test2ContextComponent), 28 },
		{ typeof(EntitasRedux.Tests.UniqueEventComponent), 29 },
		{ typeof(EntitasRedux.Tests.UniqueFlagComponent), 30 },
		{ typeof(EntitasRedux.Tests.UniqueMyNamespaceComponent), 31 },
		{ typeof(EntitasRedux.Tests.UniqueMyNamespaceFlagComponent), 32 },
		{ typeof(EntitasRedux.Tests.UniqueStandardComponent), 33 },
		{ typeof(EventToGenerateComponent), 34 },
		{ typeof(FlagEntityEventAddedListenerComponent), 35 },
		{ typeof(InterfaceToGenerateComponent), 36 },
		{ typeof(MixedEventAddedListenerComponent), 37 },
		{ typeof(NewCustomNameComponent1Component), 38 },
		{ typeof(NewCustomNameComponent2Component), 39 },
		{ typeof(StandardEntityEventRemovedListenerComponent), 40 },
		{ typeof(StructToGenerateComponent), 41 },
		{ typeof(TestAnyEventToGenerateAddedListenerComponent), 42 },
		{ typeof(TestAnyMultipleContextStandardEventAddedListenerComponent), 43 },
		{ typeof(TestAnyMultipleEventsStandardEventAddedListenerComponent), 44 },
		{ typeof(TestMultipleEventsStandardEventRemovedListenerComponent), 45 },
		{ typeof(UniqueClassToGenerateComponent), 46 }
	};

	/// <summary>
	/// Returns a component index based on the passed <paramref name="component"/> type; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="component"></param>
	public static int GetComponentIndex(IComponent component)
	{
		return GetComponentIndex(component.GetType());
	}

	/// <summary>
	/// Returns a component index based on the passed <paramref name="componentType"/>; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="componentType"></param>
	public static int GetComponentIndex(Type componentType)
	{
		return ComponentTypeToIndex.TryGetValue(componentType, out var index) ? index : -1;
	}
}
