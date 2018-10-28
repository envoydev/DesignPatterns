using FactoryMethod.Game.Enemies.Base;

namespace FactoryMethod.Game.Enemies
{
    public class DarkSoldier : IEnemy
    {
        public string BattleRoar()
        {
            return "For the dark lord";
        }

        public string Power()
        {
            return "Weak warrior with spear";
        }
    }
}
