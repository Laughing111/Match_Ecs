
using System;
using UnityEditor;

namespace Game
{
    public static class GameContextExtention
    {
        private static PieceType[] pieceTypes;
        private static UnityObjectService unityObjectService;
        static Random random;
        public static void CreateNormalPiece(this GameContext gameContext, int x, int y)
        {
            GameEntity gameEntity = gameContext.CreateEntity();
            gameEntity.AddGamePosition(x, y);
            gameEntity.isGamePiece = true;
            if (pieceTypes == null)
            {
                pieceTypes =(PieceType[])Enum.GetValues(typeof(PieceType));
                random = new Random();
            }
            PieceType pieceType= pieceTypes[random.Next(0, pieceTypes.Length)];
            gameEntity.AddGameAsset("piece"+pieceType.ToString());
            gameEntity.isGameView = true;
            
        }

        public static void CreateBlockPiece(this GameContext gameContext, int x, int y)
        {
            GameEntity gameEntity = gameContext.CreateEntity();
            gameEntity.AddGamePosition(x, y);
            gameEntity.isGamePiece = true;
            gameEntity.isGameBlock=true;
            gameEntity.AddGameAsset("block");
            gameEntity.isGameView = true;
        }
    }
}

