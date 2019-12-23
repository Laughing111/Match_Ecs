//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Game.AssetComponent gameAsset { get { return (Game.AssetComponent)GetComponent(GameComponentsLookup.GameAsset); } }
    public bool hasGameAsset { get { return HasComponent(GameComponentsLookup.GameAsset); } }

    public void AddGameAsset(string newPrefabName) {
        var index = GameComponentsLookup.GameAsset;
        var component = (Game.AssetComponent)CreateComponent(index, typeof(Game.AssetComponent));
        component.prefabName = newPrefabName;
        AddComponent(index, component);
    }

    public void ReplaceGameAsset(string newPrefabName) {
        var index = GameComponentsLookup.GameAsset;
        var component = (Game.AssetComponent)CreateComponent(index, typeof(Game.AssetComponent));
        component.prefabName = newPrefabName;
        ReplaceComponent(index, component);
    }

    public void RemoveGameAsset() {
        RemoveComponent(GameComponentsLookup.GameAsset);
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

    static Entitas.IMatcher<GameEntity> _matcherGameAsset;

    public static Entitas.IMatcher<GameEntity> GameAsset {
        get {
            if (_matcherGameAsset == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameAsset);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameAsset = matcher;
            }

            return _matcherGameAsset;
        }
    }
}
