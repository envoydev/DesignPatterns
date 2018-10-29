using System.Collections.Generic;
using FactoryMethod.GameBuilder.Enemies.Base;
using FactoryMethod.GameBuilder.Locations.Base;

namespace FactoryMethod.GameBuilder.Locations
{
    public class DarkCastle : ILocation
    {
        public int AmountEnemies { get => Enemies.Count; }
        public ICollection<IEnemy> Enemies { get; set; }

        public DarkCastle()
        {
            Enemies = new List<IEnemy>();
        }
    }
}
