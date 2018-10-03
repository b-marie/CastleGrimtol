
using System.Collections.Generic;

namespace Game
{
    abstract class Room
    {
        internal abstract int Floor { get; set; }
        internal abstract string RoomLocation { get; set; }
        internal abstract string RoomDescription { get; set; }
        internal abstract Dictionary<string, Room> Exits { get; set; }
        internal abstract Item[] RoomInventory { get; set; }


        internal abstract string ReturnRoom();
    }
}
