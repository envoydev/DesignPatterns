using FactoryMethod.GameBuilder.Enemies;
using FactoryMethod.GameBuilder.Enemies.Base;
using FactoryMethod.GameBuilder.Factory;

namespace FactoryMethod.GameBuilder.DifficultyFactories
{
    public class MediumLevel : IEnemyFactory
    {
        public IEnemy Create()
        {
            return new DarkKnight();
        }

        public override string ToString()
        {
            return "Medium level";
        }
    }
}
