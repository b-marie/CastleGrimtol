using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Room
    {
        private int Floor { get; set; }
        private string RoomLocation { get; set; }
        private string RoomDescription { get; set; }
        private string[] Exits { get; set; }
        private Item[] RoomInventory { get; set; }


    }
}
