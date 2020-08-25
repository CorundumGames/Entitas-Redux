//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public AnyMyEventClassAddedListenerComponent AnyMyEventClassAddedListener { get { return (AnyMyEventClassAddedListenerComponent)GetComponent(VisualDebugComponentsLookup.AnyMyEventClassAddedListener); } }
    public bool HasAnyMyEventClassAddedListener { get { return HasComponent(VisualDebugComponentsLookup.AnyMyEventClassAddedListener); } }

    public void AddAnyMyEventClassAddedListener(System.Collections.Generic.List<IAnyMyEventClassAddedListener> newValue) {
        var index = VisualDebugComponentsLookup.AnyMyEventClassAddedListener;
        var component = (AnyMyEventClassAddedListenerComponent)CreateComponent(index, typeof(AnyMyEventClassAddedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyMyEventClassAddedListener(System.Collections.Generic.List<IAnyMyEventClassAddedListener> newValue) {
        var index = VisualDebugComponentsLookup.AnyMyEventClassAddedListener;
        var component = (AnyMyEventClassAddedListenerComponent)CreateComponent(index, typeof(AnyMyEventClassAddedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

	public void CopyAnyMyEventClassAddedListenerTo(AnyMyEventClassAddedListenerComponent copyComponent) {
        var index = VisualDebugComponentsLookup.AnyMyEventClassAddedListener;
        var component = (AnyMyEventClassAddedListenerComponent)CreateComponent(index, typeof(AnyMyEventClassAddedListenerComponent));
        component.value = copyComponent.value;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyMyEventClassAddedListener() {
        RemoveComponent(VisualDebugComponentsLookup.AnyMyEventClassAddedListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherAnyMyEventClassAddedListener;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> AnyMyEventClassAddedListener {
        get {
            if (_matcherAnyMyEventClassAddedListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.AnyMyEventClassAddedListener);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherAnyMyEventClassAddedListener = matcher;
            }

            return _matcherAnyMyEventClassAddedListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public void AddAnyMyEventClassAddedListener(IAnyMyEventClassAddedListener value) {
        var listeners = HasAnyMyEventClassAddedListener
            ? AnyMyEventClassAddedListener.value
            : new System.Collections.Generic.List<IAnyMyEventClassAddedListener>();
        listeners.Add(value);
        ReplaceAnyMyEventClassAddedListener(listeners);
    }

    public void RemoveAnyMyEventClassAddedListener(IAnyMyEventClassAddedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = AnyMyEventClassAddedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyMyEventClassAddedListener();
        } else {
            ReplaceAnyMyEventClassAddedListener(listeners);
        }
    }
}
