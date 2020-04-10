﻿using System;

namespace Adapter
{
    class StorageAdapter : IStorage
    {
        private readonly Storage storage;

        public StorageAdapter()
        {
            storage = new Storage();
        }

        public void GetFormattedItem()
        {
            Console.WriteLine("--------------");
            storage.GetItem();
            Console.WriteLine("--------------");
        }
    }

}
