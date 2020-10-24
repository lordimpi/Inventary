using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface ICRUDData<T>
    {
        List<T> List();
        bool Create(T item);
        bool Update(T item);
        bool Delete(T item);
    }
}
