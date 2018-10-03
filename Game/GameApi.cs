using System;
using System.Collections.Generic;
using System.Text;
using Game.Rooms;

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
            Entry entry = new Entry();
            Player player = new Player("Steve");
            Game newGame = new Game(gameId, gameState, entry, player);
            _gameLog.Push(newGame);
            return _game.StartGame(userInput) + " " +  GetCurrentRoom(newGame);
        }


        public string GetGameHistory()
        {
            return _gameLog.Peek().GetGameState();
        }

        public Room ProcessCommand(string userInput, Room room)
        {
            Game currentGame = _gameLog.Pop();
            Room response = currentGame.CurrentRoom.ProcessCommand(userInput, room);
            _gameLog.Push(currentGame);
            return response;

        }

        public string GetCurrentRoom(Game game)
        {
            return game.CurrentRoom.ReturnRoom();
        }
    }
}
