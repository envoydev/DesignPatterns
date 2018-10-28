using FactoryMethod.Game.Enemies.Base;

namespace FactoryMethod.Game.Factory
{
    public interface IEnemyFactory
    {
        IEnemy Create();
    }
}
