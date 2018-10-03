using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Item
    {

        internal string ItemName { get; set; }
        internal string ItemDescription { get; set; }

        //Item constructor with name and description, not specific items, instantiate each item within the room
        public Item(string itemName, string itemDescription)
        {
            this.ItemName = itemName;
            this.ItemDescription = itemDescription;
        }

    }
}
