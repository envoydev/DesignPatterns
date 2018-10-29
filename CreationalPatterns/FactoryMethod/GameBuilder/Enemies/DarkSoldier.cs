using FactoryMethod.GameBuilder.Enemies.Base;

namespace FactoryMethod.GameBuilder.Enemies
{
    public class DarkSoldier : IEnemy
    {
        public string BattleRoar()
        {
            return "Don`t want to die";
        }

        public string Power()
        {
            return "Weak warrior with spear";
        }
    }
}
