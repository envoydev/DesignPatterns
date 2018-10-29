using FactoryMethod.GameBuilder.Enemies;
using FactoryMethod.GameBuilder.Enemies.Base;
using FactoryMethod.GameBuilder.Factory;

namespace FactoryMethod.GameBuilder.DifficultyFactories
{
    public class EasyLevel : IEnemyFactory
    {
        public IEnemy Create()
        {
            return new DarkSoldier();
        }

        public override string ToString()
        {
            return "Easy level";
        }
    }
}
