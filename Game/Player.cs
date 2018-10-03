using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Player
    {
        private string PlayerName { get; set; }
        private List<Item> PlayerInventory { get; set; }

        public Player(string playerName)
        {
            this.PlayerName = playerName;
        }

        public void AddToInventory(Item item)
        {
            PlayerInventory.Add(item);
        }

        public void UseItem(Item item)
        {
            PlayerInventory.Remove(item);
        }

        public string ReadPlayerInventory(Player player)
        {
            return player.PlayerInventory.ToString();
        }

    }
}
