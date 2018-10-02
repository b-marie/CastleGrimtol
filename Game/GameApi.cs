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


        public string GetGameHistory()
        {
            return _gameLog.Peek().GetGameState();
        }

        public string ProcessCommand(string userInput)
        {
            Game currentGame = _gameLog.Pop();
            string response = currentGame.ProcessCommand(userInput);
            _gameLog.Push(currentGame);
            return response;

        }

    }
}
