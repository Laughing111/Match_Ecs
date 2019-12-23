using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Game
{
    [Game,Unique]
    public class BoardComponent : IComponent
    {
        public int column;
        public int row;
    }
}

