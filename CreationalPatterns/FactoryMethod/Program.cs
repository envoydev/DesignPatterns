using FactoryMethod.GameBuilder;
using FactoryMethod.GameBuilder.DifficultyFactories;
using FactoryMethod.GameBuilder.Locations;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.Start(new EasyLevel(), new DarkCastle());
            newGame.Start(new MediumLevel(), new DarkCastle());
        }
    }
}
