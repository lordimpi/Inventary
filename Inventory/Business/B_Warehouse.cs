using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse : ICRUDData<WarehouseEntity>
    {
        public bool CreateItem(WarehouseEntity item)
        {
            using var db = new InventoryContext();
            db.Warehouses.Add(item);
            return db.SaveChanges() > 0;
        }

        public List<WarehouseEntity> ItemList()
        {
            using var db = new InventoryContext();
            return db.Warehouses.ToList();
        }

        public bool UpdateItem(WarehouseEntity item)
        {
            using var db = new InventoryContext();
            db.Warehouses.Update(item);
            return db.SaveChanges() > 0;
        }
        public bool DeleteItem(WarehouseEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
