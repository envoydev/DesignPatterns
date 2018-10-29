using FactoryMethod.GameBuilder.Enemies.Base;

namespace FactoryMethod.GameBuilder.Enemies
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
