using FactoryMethod.Game.Enemies.Base;

namespace FactoryMethod.Game.Enemies
{
    public class DarkDragon : IEnemy
    {
        public string BattleRoar()
        {
            return "Arrrrr";
        }

        public string Power()
        {
            return "Strong creature with fier powers";
        }
    }
}
