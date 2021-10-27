using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    interface ICRUData<T>
    {
        List<T> ItemList();

        void CreateItem(T item);

        void UpdateItem(T item);

    }
}
