using FactoryMethod.GameBuilder.Enemies.Base;

namespace FactoryMethod.GameBuilder.Enemies
{
    public class DarkKnight : IEnemy
    {
        public string BattleRoar()
        {
            return "For the dark lord";
        }

        public string Power()
        {
            return "Strong warrior with blade and shield";
        }
    }
}
