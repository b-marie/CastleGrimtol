using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Game.Items;

namespace Game.Rooms
{
    class Entry : Room
    {
        internal override string RoomDescription { get; set; } = "The room is an entry way.";
        internal override Dictionary<string, Room> Exits { get; set; } = new Dictionary<string, Room>() ;
        internal override List<Item> RoomInventory { get; set; } = new List<Item>();

        public string ReadRoomInventory(Entry room)
        {
            string result = "This room does not contain any items";
            if (room.RoomInventory != null)
            {
                result = "This room contains: ";
                foreach(var item in room.RoomInventory)
                {
                    result = result + item.ItemName + "";
                }

            }

            return result;
        }

        internal override string ReturnRoom()
        {
            Entry room = LoadRoom();
            string result = (System.Environment.NewLine + "Room: " + room.RoomDescription + System.Environment.NewLine + "Exits from this room include: " + LoadExits(room) + System.Environment.NewLine + ReadRoomInventory(room) + System.Environment.NewLine + "What would you like to do?");
            return result;
        }

        internal override Room ProcessCommand(string userInput, Room room)
        {
            switch (userInput.ToLower())
            {
                case "east":
                    return Exits["East"];
            }
        }

        internal Entry LoadRoom()
        {
            Entry room = new Entry();
            room.RoomDescription = "Description goes here";
            room.Exits = new Dictionary<string, Room>() {{"East", new SecretRoom()}};
            Item key = new Item("Ornate Key",
                "A large, ornate silvered key with a small amount of rust on the handle.");
            room.RoomInventory.Add(key);
            return room;
        }

        internal string LoadExits(Entry room)
        {
            string result = "";
            foreach (var item in room.Exits)
            {
                result = result + item.Key + " ";
            }

            return result;
        }

    }
}
