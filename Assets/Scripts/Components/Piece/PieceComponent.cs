using Entitas;

namespace Game
{
    [Game]
    public class PieceComponent:IComponent
    {
    }
    [Game]
    public class BlockComponent : IComponent
    {

    }

    [Game]
    public class DestroyComponent: IComponent
    {

    }
    [Game]
    public class PositionComponent: IComponent
    {
        public int x;
        public int y;
    }
    [Game]
    public class AssetComponent : IComponent
    {
        public string prefabName;
    }
}

