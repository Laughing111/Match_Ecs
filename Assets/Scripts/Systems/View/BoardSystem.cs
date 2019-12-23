using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Game
{
    public class BoardSystem : ReactiveSystem<GameEntity>
    {
        public GameContext gameContext;
        private int blockProbability;
        public BoardSystem(Contexts contexts) : base(contexts.game)
        {
            gameContext = contexts.game;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            //当画板创建结束后，即开始生产棋子进行填充
            int row=gameContext.gameBoard.row;
            int col = gameContext.gameBoard.column;
            for(int x = 0; x < col; x++)
            {
                for(int y = 0; y < row; y++)
                {
                    //根据位置，制作棋子实体
                    if (MathUtils.IsBlock(Config.blockProbability))
                    {
                        gameContext.CreateBlockPiece(x, y);
                    }
                    else
                    {
                        gameContext.CreateNormalPiece(x, y);
                    }
                }
            }
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasGameBoard;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.GameBoard);
        }
    }
}

