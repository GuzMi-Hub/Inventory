using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse : ICRUData<WarehouseEntity>
    {
        public void CreateItem(WarehouseEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Warehouses.Add(item);
                db.SaveChanges();
            }
        }

        public List<WarehouseEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void UpdateItem(WarehouseEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(item);
                db.SaveChanges();
            }
        }
    }
}
