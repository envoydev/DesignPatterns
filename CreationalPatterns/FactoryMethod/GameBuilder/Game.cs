using FactoryMethod.GameBuilder.Factory;
using FactoryMethod.GameBuilder.Locations.Base;
using System;

namespace FactoryMethod.GameBuilder
{
    public class Game
    {
        public void Start(IEnemyFactory difficulty, ILocation location)
        {
            Console.WriteLine($"Level of difficulty: {difficulty.ToString()}");

            for (int i = 0; i < 5; i++)
            {
                var enemy = difficulty.Create();
                location.Enemies.Add(enemy);
            }
            
            foreach (var enemy in location.Enemies)
            {
                Console.WriteLine(enemy.BattleRoar());
            }
        }
    }
}
