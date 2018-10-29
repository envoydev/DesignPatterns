using FactoryMethod.GameBuilder.Enemies.Base;

namespace FactoryMethod.GameBuilder.Factory
{
    public interface IEnemyFactory
    {
        IEnemy Create();
    }
}
