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
        public bool Create(InputOutputEntity item)
        {
            using var db = new InventoryContext();
            db.InOuts.Add(item);
            return db.SaveChanges() > 0;
        }
        public List<InputOutputEntity> List()
        {
            using var db = new InventoryContext();
            return db.InOuts.ToList();
        }

        public bool Update(InputOutputEntity item)
        {
            using var db = new InventoryContext();
            db.InOuts.Update(item);
            return db.SaveChanges() > 0;
        }
        public bool Delete(InputOutputEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
