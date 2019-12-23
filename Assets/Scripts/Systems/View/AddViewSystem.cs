using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Game
{
    public class AddViewSystem : ReactiveSystem<GameEntity>
    {

        public AddViewSystem(Contexts contexts) : base(contexts.game)
        {

        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach(var e in entities)
            {
                //创建游戏对象
                UnityObjectService.Ins.CreateAndLinkUnityObject(e);
            }
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasGameAsset & entity.isGameView;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.GameView);
        }
    }
}
