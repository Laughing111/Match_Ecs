using UnityEngine;

namespace Game
{
    public class PieceFeature : Feature
    {
        public PieceFeature(Contexts contexts)
        {
            Add(new StartGameSystem(contexts));
            Add(new BoardSystem(contexts));
            Add(new AddViewSystem(contexts));
        }
    }
}

