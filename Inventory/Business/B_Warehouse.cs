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
        public bool Create(WarehouseEntity item)
        {
            using var db = new InventoryContext();
            db.Warehouses.Add(item);
            return db.SaveChanges() > 0;
        }

        public List<WarehouseEntity> List()
        {
            using var db = new InventoryContext();
            return db.Warehouses.ToList();
        }

        public bool Update(WarehouseEntity item)
        {
            using var db = new InventoryContext();
            db.Warehouses.Update(item);
            return db.SaveChanges() > 0;
        }
        public bool Delete(WarehouseEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
