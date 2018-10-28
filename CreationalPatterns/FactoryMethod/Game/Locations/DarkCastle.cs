using System.Collections.Generic;
using FactoryMethod.Game.Enemies.Base;
using FactoryMethod.Game.Locations.Base;

namespace FactoryMethod.Game.Locations
{
    public class DarkCastle : ILocation
    {
        public int AmountEnemies { get => Enemies.Count; }

        public ICollection<IEnemy> Enemies { get; set; }
    }
}
