using UnityEngine;

namespace Game
{
    public class UnityObjectService : MonoSingleton<UnityObjectService>, IUnityObjectService
    {
        public Transform root;
        protected override void Init()
        {
            root=GameObject.Find("Pieces").transform;
        }
        /// <summary>
        /// 创建Unity物体，并链接Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public GameObject CreateAndLinkUnityObject(GameEntity entity)
        {
            string prefabName = entity.gameAsset.prefabName;
            GameObject pieceObject = null;
            if (prefabName != null)
            {
                GameObject  piecePrefab= Resources.Load<GameObject>(prefabName);
                pieceObject = Instantiate(piecePrefab);
                pieceObject.transform.position = GetBoardPos(entity.gamePosition.x, entity.gamePosition.y);
                pieceObject.transform.SetParent(root, false);
            }
            return pieceObject;
        }

        private Vector2 GetBoardPos(int x,int y)
        {
            return Config.boardStartPos + new Vector2(x, -y) * Config.pieceWidth;
        }
    }
}
