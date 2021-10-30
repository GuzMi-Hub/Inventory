using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class B_Category : ICRUData<CategoryEntity>
    {
        public void CreateItem(CategoryEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Add(item);
                db.SaveChanges();
            }
        }

        public List<CategoryEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }


        public void UpdateItem(CategoryEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(item);
                db.SaveChanges();
            }
        }

        public CategoryEntity ItemById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList().FirstOrDefault(category => category.CategoryId == id);
            }
        }
    }
}
