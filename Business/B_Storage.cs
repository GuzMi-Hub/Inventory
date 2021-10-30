using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage : ICRUData<StorageEntity>
    {
        public void CreateItem(StorageEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(item);
                db.SaveChanges();
            }
        }

        public List<StorageEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }


        public List<StorageEntity> StorageProductsByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(storage => storage.Product)
                    .Include(storage => storage.Warehouse)
                    .Where(storage => storage.WarehouseId == idWarehouse)
                    .ToList();
            }
        }


        public StorageEntity ItemById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList().FirstOrDefault(storage => storage.StorageId == id);
            }
        }

        public void UpdateItem(StorageEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(item);
                db.SaveChanges();
            }
        }
        public bool IsProductInWarehouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList()
                       .Where(storage => storage.StorageId == idStorage);

                var resultado = product.Any();
                return resultado;
            }
        }
    }
}
