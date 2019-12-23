//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Game.DestroyComponent gameDestroyComponent = new Game.DestroyComponent();

    public bool isGameDestroy {
        get { return HasComponent(GameComponentsLookup.GameDestroy); }
        set {
            if (value != isGameDestroy) {
                var index = GameComponentsLookup.GameDestroy;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : gameDestroyComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGameDestroy;

    public static Entitas.IMatcher<GameEntity> GameDestroy {
        get {
            if (_matcherGameDestroy == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameDestroy);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameDestroy = matcher;
            }

            return _matcherGameDestroy;
        }
    }
}