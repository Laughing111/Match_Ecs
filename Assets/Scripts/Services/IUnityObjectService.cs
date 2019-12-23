
using UnityEngine;

namespace Game
{
    public interface IUnityObjectService
    {
        GameObject CreateAndLinkUnityObject(GameEntity entity);
    }
}
