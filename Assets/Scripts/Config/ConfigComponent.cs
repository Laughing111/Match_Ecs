
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Game
{
    public class Config
    {
        public static int boardRow;
        public static int boardCol;
        public static int blockProbability;

        public static int pieceWidth;
        public static Vector2 boardStartPos;
        public static void LoadData(ConfigResource scriptableObject)
        {
            boardCol = scriptableObject.boardColumn;
            boardRow = scriptableObject.boardRow;
            blockProbability = scriptableObject.blockProbability;
            pieceWidth = scriptableObject.pieceWidth;
            boardStartPos = scriptableObject.boardStartPos;
        }
    }

    [CreateAssetMenu(menuName ="CreateConfigResource",order =0)]
    public class ConfigResource : ScriptableObject
    {
        
        public int boardColumn;
        public int boardRow;
        public int blockProbability;
        public int pieceWidth;
        public Vector2 boardStartPos;
    }

    public enum PieceType
    {
        A,
        B,
        C,
        D,
        E
    }
}

