
using System.Collections.Generic;

namespace Game
{
    public abstract class Room
    {
        internal abstract string RoomDescription { get; set; }
        internal abstract Dictionary<string, Room> Exits { get; set; }
        internal abstract List<Item> RoomInventory { get; set; }


        internal abstract string ReturnRoom();

        internal abstract Room ProcessCommand(string userInput, Room room);
    }
}
