using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Items
{
    class MagicKey
    {

        internal string ItemName;
        internal string ItemDescription;

        public MagicKey LoadMagicKey()
        {
            MagicKey magicKey = new MagicKey();
            magicKey.ItemName = "Ornate Key";
            magicKey.ItemDescription = "A large, ornate silvered key with a small amount of rust on the handle.";
            return magicKey;
        }
    }
}
