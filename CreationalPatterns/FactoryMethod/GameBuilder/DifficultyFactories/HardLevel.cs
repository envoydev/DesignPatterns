using FactoryMethod.GameBuilder.Enemies;
using FactoryMethod.GameBuilder.Enemies.Base;
using FactoryMethod.GameBuilder.Factory;

namespace FactoryMethod.GameBuilder.DifficultyFactories
{
    public class HardLevel : IEnemyFactory
    {
        public IEnemy Create()
        {
            return new DarkDragon();
        }

        public override string ToString()
        {
            return "Hard level";
        }
    }
}
