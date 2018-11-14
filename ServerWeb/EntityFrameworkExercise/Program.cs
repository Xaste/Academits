using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (var db = new ProductContext())
            {
                db.Categories.Add(new Category { Name = "Процессоры" });
                db.Categories.Add(new Category { Name = "Мониторы" });

                db.SaveChanges();
            }*/

            /*using (var db = new ProductContext())
            {
                var category = db.Categories.FirstOrDefault(c => c.Id == 1);
                category.Name = "Процессоры Intel";
                db.SaveChanges();
            }*/

            /*using (var db = new ProductContext())
            {
                var category = new Category { Id = 1 };

                db.Entry(category).State = EntityState.Deleted;

                db.SaveChanges();
            }*/

            /*using (var db = new ProductContext())
            {
                var product = new Product
                {
                    Name = "Intel Core i7",
                    //Category = new Category { Name = "Процессоры" }
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Процессоры")
                };

                db.Products.Add(product);
                db.SaveChanges();
            }*/

            /*using (var db = new ProductContext())  //TODO Не работает, спросить
            {
                var product = db.Products.FirstOrDefault(p => p.Id == 2);
                Console.WriteLine(product.Category.Name);
            }*/
        }
    }
}
