using FactoryMethod.Game.Enemies.Base;
using System.Collections.Generic;

namespace FactoryMethod.Game.Locations.Base
{
    public interface ILocation
    {
        int AmountEnemies { get; }

        ICollection<IEnemy> Enemies { get; set; }
    }
}
