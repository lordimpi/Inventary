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
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList();
            }
        }
        public bool CreateItem(CategoryEntity item)
        {
            using (var db = new InventoryContext())
            {
                CategoryEntity categoryEntity = db.Categories.Find(item.CategoryId);
                if (categoryEntity != null)
                {
                    db.Categories.Add(categoryEntity);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool UpdateItem(CategoryEntity item)
        {
            using (var db = new InventoryContext())
            {
                CategoryEntity categoryEntity = db.Categories.Find(item.CategoryId);
                if (categoryEntity != null)
                {
                    db.Categories.Update(categoryEntity);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool DeleteItem(CategoryEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
