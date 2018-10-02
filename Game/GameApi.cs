using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class GameApi
    {
        private Game _game = new Game();
        Stack<Game> _gameLog = new Stack<Game>();
        

        public string StartGame(string userInput)
        {
            Guid gameId = new Guid();
            String gameState = "running";
            Game newGame = new Game(gameId, gameState);
            _gameLog.Push(newGame);
            return _game.StartGame(userInput);
        }


    }
}
