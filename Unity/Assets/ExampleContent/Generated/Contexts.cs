public partial class Contexts : JCMG.EntitasRedux.IContexts
{
	#if UNITY_EDITOR

	static Contexts()
	{
		UnityEditor.EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
	}

	/// <summary>
	/// Invoked when the Unity Editor has a <see cref="UnityEditor.PlayModeStateChange"/> change.
	/// </summary>
	private static void OnPlayModeStateChanged(UnityEditor.PlayModeStateChange playModeStateChange)
	{
		// When entering edit-mode, reset all static state so that it does not interfere with the
		// next play-mode session.
		if (playModeStateChange == UnityEditor.PlayModeStateChange.EnteredEditMode)
		{
			_sharedInstance = null;
		}
	}

	#endif

	public static Contexts SharedInstance
	{
		get
		{
			if (_sharedInstance == null)
			{
				_sharedInstance = new Contexts();
			}

			return _sharedInstance;
		}
		set	{ _sharedInstance = value; }
	}

	static Contexts _sharedInstance;

	public EmptyContext Empty { get; set; }
	public ExampleContext Example { get; set; }
	public GameContext Game { get; set; }
	public VisualDebugContext VisualDebug { get; set; }

	public JCMG.EntitasRedux.IContext[] AllContexts { get { return new JCMG.EntitasRedux.IContext [] { Empty, Example, Game, VisualDebug }; } }

	public Contexts()
	{
		Empty = new EmptyContext();
		Example = new ExampleContext();
		Game = new GameContext();
		VisualDebug = new VisualDebugContext();

		var postConstructors = System.Linq.Enumerable.Where(
			GetType().GetMethods(),
			method => System.Attribute.IsDefined(method, typeof(JCMG.EntitasRedux.PostConstructorAttribute))
		);

		foreach (var postConstructor in postConstructors)
		{
			postConstructor.Invoke(this, null);
		}
	}

	public void Reset()
	{
		var contexts = AllContexts;
		for (int i = 0; i < contexts.Length; i++)
		{
			contexts[i].Reset();
		}
	}
}

public partial class Contexts
{
	public const string ExampleContentVisualDebuggingCustomIndexesColorPositionEntityIndex = "ExampleContentVisualDebuggingCustomIndexesColorPositionEntityIndex";
	public const string IndexedEntity = "IndexedEntity";
	public const string IndexedPrimary = "IndexedPrimary";

	[JCMG.EntitasRedux.PostConstructor]
	public void InitializeEntityIndices()
	{
		VisualDebug.AddEntityIndex(new ExampleContent.VisualDebugging.CustomIndexes.ColorPositionEntityIndex(VisualDebug));

		VisualDebug.AddEntityIndex(new JCMG.EntitasRedux.EntityIndex<VisualDebugEntity, int>(
			IndexedEntity,
			VisualDebug.GetGroup(VisualDebugMatcher.IndexedEntity),
			(e, c) => ((ExampleContent.VisualDebugging.IndexedEntityComponent)c).id));

		VisualDebug.AddEntityIndex(new JCMG.EntitasRedux.PrimaryEntityIndex<VisualDebugEntity, int>(
			IndexedPrimary,
			VisualDebug.GetGroup(VisualDebugMatcher.IndexedPrimary),
			(e, c) => ((ExampleContent.VisualDebugging.IndexedPrimaryComponent)c).id));
	}
}

public static class ContextsExtensions
{
	public static System.Collections.Generic.HashSet<VisualDebugEntity> GetColorEntitiesAtPosition(this VisualDebugContext context, ExampleContent.VisualDebugging.IntVector2 pos)
	{
		return ((ExampleContent.VisualDebugging.CustomIndexes.ColorPositionEntityIndex)(context.GetEntityIndex(Contexts.ExampleContentVisualDebuggingCustomIndexesColorPositionEntityIndex))).GetColorEntitiesAtPosition(pos);
	}

	public static System.Collections.Generic.HashSet<VisualDebugEntity> GetEntitiesWithIndexedEntity(this VisualDebugContext context, int id)
	{
		return ((JCMG.EntitasRedux.EntityIndex<VisualDebugEntity, int>)context.GetEntityIndex(Contexts.IndexedEntity)).GetEntities(id);
	}

	public static VisualDebugEntity GetEntityWithIndexedPrimary(this VisualDebugContext context, int id)
	{
		return ((JCMG.EntitasRedux.PrimaryEntityIndex<VisualDebugEntity, int>)context.GetEntityIndex(Contexts.IndexedPrimary)).GetEntity(id);
	}
}
public partial class Contexts {

#if (!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)

	[JCMG.EntitasRedux.PostConstructor]
	public void InitializeContextObservers() {
		try {
			CreateContextObserver(Empty);
			CreateContextObserver(Example);
			CreateContextObserver(Game);
			CreateContextObserver(VisualDebug);
		} catch(System.Exception) {
		}
	}

	public void CreateContextObserver(JCMG.EntitasRedux.IContext context) {
		if (UnityEngine.Application.isPlaying) {
			var observer = new JCMG.EntitasRedux.VisualDebugging.ContextObserver(context);
			UnityEngine.Object.DontDestroyOnLoad(observer.GameObject);
		}
	}

#endif
}
