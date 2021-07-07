
using JCMG.EntitasRedux;

public partial class MyTestEntity
{
	/// <summary>
	/// Copies <paramref name="component"/> to this entity as a new component instance.
	/// </summary>
	public void CopyComponentTo(IComponent component)
	{
		#if !ENTITAS_REDUX_NO_IMPL
		if (component is EntitasRedux.Tests.ComponentA ComponentA)
		{
			IsComponentA = true;
		}
		else if (component is EntitasRedux.Tests.ComponentB ComponentB)
		{
			IsComponentB = true;
		}
		else if (component is EntitasRedux.Tests.ComponentC ComponentC)
		{
			IsComponentC = true;
		}
		else if (component is EntitasRedux.Tests.ComponentD ComponentD)
		{
			IsComponentD = true;
		}
		else if (component is EntitasRedux.Tests.ComponentE ComponentE)
		{
			IsComponentE = true;
		}
		else if (component is EntitasRedux.Tests.ComponentF ComponentF)
		{
			IsComponentF = true;
		}
		else if (component is EntitasRedux.Tests.Array3dComponent Array3d)
		{
			CopyArray3dTo(Array3d);
		}
		else if (component is EntitasRedux.Tests.CleanupDestroyComponent CleanupDestroy)
		{
			IsCleanupDestroy = true;
		}
		else if (component is EntitasRedux.Tests.CleanupRemoveComponent CleanupRemove)
		{
			IsCleanupRemove = true;
		}
		else if (component is EntitasRedux.Tests.DeepCopyComponent DeepCopy)
		{
			CopyDeepCopyTo(DeepCopy);
		}
		else if (component is EntitasRedux.Tests.EntityIndexNoContextComponent EntityIndexNoContext)
		{
			CopyEntityIndexNoContextTo(EntityIndexNoContext);
		}
		else if (component is EntitasRedux.Tests.InheritedComponent Inherited)
		{
			CopyInheritedTo(Inherited);
		}
		else if (component is EntitasRedux.Tests.ParentComponent Parent)
		{
			CopyParentTo(Parent);
		}
		else if (component is EntitasRedux.Tests.MultiplePrimaryEntityIndicesComponent MultiplePrimaryEntityIndices)
		{
			CopyMultiplePrimaryEntityIndicesTo(MultiplePrimaryEntityIndices);
		}
		else if (component is EntitasRedux.Tests.NameAgeComponent NameAge)
		{
			CopyNameAgeTo(NameAge);
		}
		else if (component is EntitasRedux.Tests.NoContextComponent NoContext)
		{
			IsNoContext = true;
		}
		else if (component is EntitasRedux.Tests.PrimaryEntityIndexComponent PrimaryEntityIndex)
		{
			CopyPrimaryEntityIndexTo(PrimaryEntityIndex);
		}
		else if (component is EntitasRedux.Tests.ShallowCopyComponent ShallowCopy)
		{
			CopyShallowCopyTo(ShallowCopy);
		}
		#endif
	}

	/// <summary>
	/// Copies all components on this entity to <paramref name="copyToEntity"/>.
	/// </summary>
	public void CopyTo(MyTestEntity copyToEntity)
	{
		for (var i = 0; i < MyTestComponentsLookup.TotalComponents; ++i)
		{
			if (HasComponent(i))
			{
				if (copyToEntity.HasComponent(i))
				{
					throw new EntityAlreadyHasComponentException(
						i,
						"Cannot copy component '" +
						MyTestComponentsLookup.ComponentNames[i] +
						"' to " +
						this +
						"!",
						"If replacement is intended, please call CopyTo() with `replaceExisting` set to true.");
				}

				var component = GetComponent(i);
				copyToEntity.CopyComponentTo(component);
			}
		}
	}

	/// <summary>
	/// Copies all components on this entity to <paramref name="copyToEntity"/>; if <paramref name="replaceExisting"/>
	/// is true any of the components that <paramref name="copyToEntity"/> has that this entity has will be replaced,
	/// otherwise they will be skipped.
	/// </summary>
	public void CopyTo(MyTestEntity copyToEntity, bool replaceExisting)
	{
		for (var i = 0; i < MyTestComponentsLookup.TotalComponents; ++i)
		{
			if (!HasComponent(i))
			{
				continue;
			}

			if (!copyToEntity.HasComponent(i) || replaceExisting)
			{
				var component = GetComponent(i);
				copyToEntity.CopyComponentTo(component);
			}
		}
	}

	/// <summary>
	/// Copies components on this entity at <paramref name="indices"/> in the <see cref="MyTestComponentsLookup"/> to
	/// <paramref name="copyToEntity"/>. If <paramref name="replaceExisting"/> is true any of the components that
	/// <paramref name="copyToEntity"/> has that this entity has will be replaced, otherwise they will be skipped.
	/// </summary>
	public void CopyTo(MyTestEntity copyToEntity, bool replaceExisting, params int[] indices)
	{
		for (var i = 0; i < indices.Length; ++i)
		{
			var index = indices[i];

			// Validate that the index is within range of the component lookup
			if (index < 0 && index >= MyTestComponentsLookup.TotalComponents)
			{
				const string OUT_OF_RANGE_WARNING =
					"Component Index [{0}] is out of range for [{1}].";

				const string HINT = "Please ensure any CopyTo indices are valid.";

				throw new IndexOutOfLookupRangeException(
					string.Format(OUT_OF_RANGE_WARNING, index, nameof(MyTestComponentsLookup)),
					HINT);
			}

			if (!HasComponent(index))
			{
				continue;
			}

			if (!copyToEntity.HasComponent(index) || replaceExisting)
			{
				var component = GetComponent(index);
				copyToEntity.CopyComponentTo(component);
			}
		}
	}
}
