using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class InputOutpuEntity
    {
        //Relación con categorías (CategoryEntity)
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //Relación con almacenamiento (StorageEntity)
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
