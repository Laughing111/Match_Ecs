//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Game.PositionComponent gamePosition { get { return (Game.PositionComponent)GetComponent(GameComponentsLookup.GamePosition); } }
    public bool hasGamePosition { get { return HasComponent(GameComponentsLookup.GamePosition); } }

    public void AddGamePosition(int newX, int newY) {
        var index = GameComponentsLookup.GamePosition;
        var component = (Game.PositionComponent)CreateComponent(index, typeof(Game.PositionComponent));
        component.x = newX;
        component.y = newY;
        AddComponent(index, component);
    }

    public void ReplaceGamePosition(int newX, int newY) {
        var index = GameComponentsLookup.GamePosition;
        var component = (Game.PositionComponent)CreateComponent(index, typeof(Game.PositionComponent));
        component.x = newX;
        component.y = newY;
        ReplaceComponent(index, component);
    }

    public void RemoveGamePosition() {
        RemoveComponent(GameComponentsLookup.GamePosition);
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

    static Entitas.IMatcher<GameEntity> _matcherGamePosition;

    public static Entitas.IMatcher<GameEntity> GamePosition {
        get {
            if (_matcherGamePosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GamePosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGamePosition = matcher;
            }

            return _matcherGamePosition;
        }
    }
}
