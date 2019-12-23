using Entitas;

namespace Game
{
    public class StartGameSystem : IInitializeSystem
    {
        private GameContext gameContext;
        public StartGameSystem(Contexts contexts)
        {
            gameContext = contexts.game;
        }

        public void Initialize()
        {
            GameEntity boardEntity= gameContext.CreateEntity();
            boardEntity.AddGameBoard(Config.boardCol, Config.boardRow);
        }
    }
}
