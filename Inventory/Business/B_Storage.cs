using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage : ICRUDData<StorageEntity>
    {
        public bool CreateItem(StorageEntity item)
        {
            using var db = new InventoryContext();
            db.Storages.Add(item);
            return db.SaveChanges() > 0;
        }

        public List<StorageEntity> ItemList()
        {
            using var db = new InventoryContext();
            return db.Storages.ToList();
        }

        public bool UpdateItem(StorageEntity item)
        {
            using var db = new InventoryContext();
            db.Storages.Update(item);
            return db.SaveChanges() > 0;
        }
        public bool DeleteItem(StorageEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
