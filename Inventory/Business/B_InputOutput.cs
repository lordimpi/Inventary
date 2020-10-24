using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Business
{
    public class B_InputOutput : ICRUDData<InputOutputEntity>
    {
        public bool CreateItem(InputOutputEntity item)
        {
            using var db = new InventoryContext();
            db.InOuts.Add(item);
            return db.SaveChanges() > 0;
        }
        public List<InputOutputEntity> ItemList()
        {
            using var db = new InventoryContext();
            return db.InOuts.ToList();
        }

        public bool UpdateItem(InputOutputEntity item)
        {
            using var db = new InventoryContext();
            db.InOuts.Update(item);
            return db.SaveChanges() > 0;
        }
        public bool DeleteItem(InputOutputEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
