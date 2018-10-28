using FactoryMethod.Game.Enemies.Base;
using FactoryMethod.Game.Factory;

namespace FactoryMethod.Game.DifficultyFactories
{
    public class EasyLevel : IEnemyFactory
    {
        public IEnemy Create()
        {
            throw new System.NotImplementedException();
        }
    }
}
