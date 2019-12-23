
using Entitas;
using UnityEngine;
namespace Game
{
    public class GameRootService : MonoBehaviour
    {
        private Systems systems;
        private PieceFeature feature;
        public ConfigResource configResource;
        private void Awake()
        {
            Contexts contexts = Contexts.sharedInstance;
            feature = new PieceFeature(contexts);
            Config.LoadData(configResource);
            feature.Initialize();
        }

        private void Update()
        {
            feature.Execute();
        }

        private void LateUpdate()
        {
            feature.Cleanup();
        }
    }
}
