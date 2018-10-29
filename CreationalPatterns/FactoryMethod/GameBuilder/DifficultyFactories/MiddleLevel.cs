using FactoryMethod.GameBuilder.Enemies;
using FactoryMethod.GameBuilder.Enemies.Base;
using FactoryMethod.GameBuilder.Factory;

namespace FactoryMethod.GameBuilder.DifficultyFactories
{
    public class MiddleLevel : IEnemyFactory
    {
        public IEnemy Create()
        {
            return new DarkKnight();
        }

        public override string ToString()
        {
            return "Middle level";
        }
    }
}
