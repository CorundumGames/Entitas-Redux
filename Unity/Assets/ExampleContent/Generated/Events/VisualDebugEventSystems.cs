//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class VisualDebugEventSystems : Feature {

    public VisualDebugEventSystems(Contexts contexts) {
        Add(new AnyMyEventEventSystem(contexts)); // priority: 0
        Add(new AnyMyEventClassEventSystem(contexts)); // priority: 0
    }
}