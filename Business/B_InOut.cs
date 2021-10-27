using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InOut : ICRUData<InOutEntity>
    {
        public void CreateItem(InOutEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(item);
                db.SaveChanges();
            }
        }

        public List<InOutEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void UpdateItem(InOutEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(item);
                db.SaveChanges();
            }
        }
    }
}
