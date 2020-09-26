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

    public ExampleContent.VisualDebugging.RectComponent Rect { get { return (ExampleContent.VisualDebugging.RectComponent)GetComponent(VisualDebugComponentsLookup.Rect); } }
    public bool HasRect { get { return HasComponent(VisualDebugComponentsLookup.Rect); } }

    public void AddRect(UnityEngine.Rect newRect) {
        var index = VisualDebugComponentsLookup.Rect;
        var component = (ExampleContent.VisualDebugging.RectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.RectComponent));
        component.rect = newRect;
        AddComponent(index, component);
    }

    public void ReplaceRect(UnityEngine.Rect newRect) {
        var index = VisualDebugComponentsLookup.Rect;
        var component = (ExampleContent.VisualDebugging.RectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.RectComponent));
        component.rect = newRect;
        ReplaceComponent(index, component);
    }

	public void CopyRectTo(ExampleContent.VisualDebugging.RectComponent copyComponent) {
        var index = VisualDebugComponentsLookup.Rect;
        var component = (ExampleContent.VisualDebugging.RectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.RectComponent));
        component.rect = copyComponent.rect;
        ReplaceComponent(index, component);
    }

    public void RemoveRect() {
        RemoveComponent(VisualDebugComponentsLookup.Rect);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherRect;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Rect {
        get {
            if (_matcherRect == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Rect);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherRect = matcher;
            }

            return _matcherRect;
        }
    }
}
