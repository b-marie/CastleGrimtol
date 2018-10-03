using System.Collections.Generic;

namespace Game.Rooms
{
    class SecretRoom : Room
    {
        internal override string RoomDescription { get; set; } = "The room is super secret.";
        internal override Dictionary<string, Room> Exits { get; set; } = new Dictionary<string, Room>();
        internal override List<Item> RoomInventory { get; set; }

        public string ReadRoomInventory(SecretRoom room)
        {
            string result = "This room does not contain any items";
            if (room.RoomInventory != null)
            {
                result = "This room contains: ";
                foreach (var item in room.RoomInventory)
                {
                    result = result + item + "";
                }

            }

            return result;
        }

        internal override string ReturnRoom()
        {
            SecretRoom secretRoom = LoadRoom();
            string result = ("Room: " + secretRoom.RoomDescription + " Exits from this room include: " + secretRoom.Exits.Keys + " " + secretRoom.ReadRoomInventory(secretRoom));
            return result;
        }

        internal override string ProcessCommand(string userInput)
        {
            throw new System.NotImplementedException();
        }

        internal SecretRoom LoadRoom()
        {
            SecretRoom secretRoom = new SecretRoom();
            secretRoom.RoomDescription = "This room is super secret!";
            secretRoom.Exits = new Dictionary<string, Room>() { { "West", new Entry() } };
            return secretRoom;
        }

    }
}