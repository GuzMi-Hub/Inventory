using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product : ICRUData<ProductEntity>
    {
        public void CreateItem(ProductEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Products.Add(item);
                db.SaveChanges();
            }
        }

        public ProductEntity ItemById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList().FirstOrDefault(product => product.ProductId == id);
            }
        }

        public List<ProductEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public void UpdateItem(ProductEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(item);
                db.SaveChanges();
            }
        }

        

    }
}
