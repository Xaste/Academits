using EntityFrameworkExercise.DB;
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
            //Database.CreateDatabase();

            //Database.AddInDataBase();

            //Database.ChangeInDataBase();

            //Database.DeleteInDataBase();

            //var mostValuableProduct = Database.FindMostBuyableProduct();

            //Console.WriteLine(mostValuableProduct);

            //Database.PrintCustomersExpenses();

            Database.PrintCategoriesStatistic();

            /*using (var db = new ProductContext())  //TODO Не работает, спросить
            {
                var product = db.Products.FirstOrDefault(p => p.Id == 2);
                Console.WriteLine(product.Category.Name);
            }*/
        }
    }
}
