using FactoryMethod.Game.Enemies.Base;

namespace FactoryMethod.Game.Enemies
{
    public class DarkKnight : IEnemy
    {
        public string BattleRoar()
        {
            return "For the datrk king";
        }

        public string Power()
        {
            return "Strong warrior with blade and shield";
        }
    }
}
