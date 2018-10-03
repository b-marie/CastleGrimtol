using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace Game.Rooms
{
    class Entry : Room
    {
        internal override int Floor { get; set; } = 1;
        internal override string RoomLocation { get; set; } = "B3";
        internal override string RoomDescription { get; set; } = "The room is an entry way.";
        internal override Dictionary<string, Room> Exits { get; set; } = new Dictionary<string, Room>() ;
        internal override Item[] RoomInventory { get; set; }

        public string ReadRoomInventory(Entry room)
        {
            string result = "This room does not contain any items";
            if (room.RoomInventory != null)
            {
                result = "This room contains: ";
                foreach(var item in room.RoomInventory)
                {
                    result = result + item + "";
                }

            }

            return result;
        }

        internal override string ReturnRoom()
        {
            Entry entry = LoadRoom();
            string result = ("Room: " + entry.RoomDescription + " Exits from this room include: " + entry.Exits.Keys + " " + " inventory ");
            return result;
        }

        internal Entry LoadRoom()
        {
            Entry entry = new Entry();
            entry.Floor = 1;
            entry.RoomLocation = "B3";
            entry.RoomDescription = "Description goes here";
            entry.Exits = new Dictionary<string, Room>() { { "North", new Entry() } };
            //Item newItem = new Item();
            //entry.RoomInventory = [newItem];
            return entry;
        }
    }
}
