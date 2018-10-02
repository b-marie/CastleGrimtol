using System;
using Game;

namespace CastleGrimtol
{
    class Program
    {
        static void Main(string[] args)
        {
            GameApi gameApi = new GameApi();


            Console.WriteLine("Welcome to the Castle Grimtol Text Adventure Game!");
            Console.WriteLine("Would you like to play a game? (Yes No or Tutorial)");
            var userResponse = Console.ReadLine();
            Console.WriteLine(gameApi.StartGame(userResponse));
            Console.ReadLine();
            Console.WriteLine(gameApi.GetGameHistory());
            Console.Read();
        }
    }
}
