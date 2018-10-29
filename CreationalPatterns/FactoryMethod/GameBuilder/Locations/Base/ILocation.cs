using FactoryMethod.GameBuilder.Enemies.Base;
using System.Collections.Generic;

namespace FactoryMethod.GameBuilder.Locations.Base
{
    public interface ILocation
    {
        int AmountEnemies { get; }
        ICollection<IEnemy> Enemies { get; set; }
    }
}
