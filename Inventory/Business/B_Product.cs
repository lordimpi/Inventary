using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product : ICRUDData<ProductEntity>
    {
        public bool Create(ProductEntity item)
        {
            using var db = new InventoryContext();
            db.Products.Add(item);
            return db.SaveChanges() > 0;
        }
        public List<ProductEntity> List()
        {
            using var db = new InventoryContext();
            return db.Products.ToList();
        }
        public bool Update(ProductEntity item)
        {
            using var db = new InventoryContext();
            db.Products.Update(item);
            return db.SaveChanges() > 0;
        }
        public bool Delete(ProductEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
