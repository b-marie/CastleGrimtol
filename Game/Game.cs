using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Game
    {
        private Guid GameId { get; set; }
        private string GameState { get; set; }
        internal Room CurrentRoom { get; set; }

        internal Game(Guid gameId, string gameState, Room currentRoom)
        {
            this.GameId = gameId;
            this.GameState = gameState;
            this.CurrentRoom = currentRoom;
        }

        internal Game()
        {

        }


        internal string StartGame(string startGame)
        {
            string userResponse = startGame.ToLower();

            if (userResponse == "yes")
            {
                return "Your vision slowly returns to you as you sit up and look around a room, with no memory of how you got here. Entry text will go here";
            }

            if (userResponse == "no")
            {
                return "Thank you for playing!";
            }

            if (userResponse == "tutorial")
            {
                return "Let's do a tutorial!";
            }

            return "Please select yes, no, or tutorial";

        }

        internal string ProcessCommand(string userInput)
        {

            return "This is the command response";

        }

        internal void Quit()
        {

        }

        internal string GetGameState()
        {
            return this.GameState;
        }

    }
}
