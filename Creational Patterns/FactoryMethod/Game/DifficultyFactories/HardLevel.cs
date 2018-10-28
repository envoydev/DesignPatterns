using FactoryMethod.Game.Enemies.Base;
using FactoryMethod.Game.Factory;

namespace FactoryMethod.Game.DifficultyFactories
{
    public class HardLevel : IEnemyFactory
    {
        public IEnemy Create()
        {
            throw new System.NotImplementedException();
        }
    }
}
