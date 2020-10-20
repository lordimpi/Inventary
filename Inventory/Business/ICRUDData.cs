using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface ICRUDData<T>
    {
        List<T> ItemList();
        bool CreateItem(T item);
        bool UpdateItem(T item);
        bool DeleteItem(T item);
    }
}
