namespace Adapter
{
    class StorageAdapter : IStorage
    {
        private readonly Storage storage;

        public StorageAdapter(Storage storage)
        {
            this.storage = storage;
        }

        public void GetFormattedItem()
        {
            storage.GetItem();
        }
    }

}
