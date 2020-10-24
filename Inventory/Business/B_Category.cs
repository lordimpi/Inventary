using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category : ICRUDData<CategoryEntity>
    {
        public List<CategoryEntity> ItemList()
        {
            using var db = new InventoryContext();
            return db.Categories.ToList();
        }
        public bool CreateItem(CategoryEntity item)
        {
            using var db = new InventoryContext();
            db.Categories.Add(item);
            return db.SaveChanges() > 0;
        }
        public bool UpdateItem(CategoryEntity item)
        {
            using var db = new InventoryContext();
            db.Categories.Update(item);
            return db.SaveChanges() > 0;
        }
        public bool DeleteItem(CategoryEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
