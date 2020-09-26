//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public ExampleContent.VisualDebugging.TextureComponent Texture { get { return (ExampleContent.VisualDebugging.TextureComponent)GetComponent(VisualDebugComponentsLookup.Texture); } }
    public bool HasTexture { get { return HasComponent(VisualDebugComponentsLookup.Texture); } }

    public void AddTexture(UnityEngine.Texture newTexture) {
        var index = VisualDebugComponentsLookup.Texture;
        var component = (ExampleContent.VisualDebugging.TextureComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.TextureComponent));
        component.texture = newTexture;
        AddComponent(index, component);
    }

    public void ReplaceTexture(UnityEngine.Texture newTexture) {
        var index = VisualDebugComponentsLookup.Texture;
        var component = (ExampleContent.VisualDebugging.TextureComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.TextureComponent));
        component.texture = newTexture;
        ReplaceComponent(index, component);
    }

	public void CopyTextureTo(ExampleContent.VisualDebugging.TextureComponent copyComponent) {
        var index = VisualDebugComponentsLookup.Texture;
        var component = (ExampleContent.VisualDebugging.TextureComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.TextureComponent));
        component.texture = copyComponent.texture;
        ReplaceComponent(index, component);
    }

    public void RemoveTexture() {
        RemoveComponent(VisualDebugComponentsLookup.Texture);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherTexture;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Texture {
        get {
            if (_matcherTexture == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Texture);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherTexture = matcher;
            }

            return _matcherTexture;
        }
    }
}
