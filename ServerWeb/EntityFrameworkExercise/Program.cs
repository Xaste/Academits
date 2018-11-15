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
            using (var db = new ProductContext())
            {
                var categoryProc = new Category { Name = "Процессоры" };
                var categoryScreen = new Category { Name = "Мониторы" };

                var product1 = new Product
                {
                    Name = "Intel core i7",
                    Category = categoryProc,
                    Price = 25000
                };
                var product2 = new Product
                {
                    Name = "Asus Screen",
                    Category = categoryScreen,
                    Price = 30000
                };
                var prodcut3 = new Product
                {
                    Name = "Intel core i5",
                    Category = categoryProc,
                    Price = 15000
                };
                var product4 = new Product
                {
                    Name = "Asus Screen v2",
                    Category = categoryScreen,
                    Price = 50000
                };

                var order1 = new Order
                {
                    Date = DateTime.Now,
                    Customer = new Customer() { FirstName = "Vlad", LastName = "Martyn", Phone = 7777777, EMail = "mail@mail.mail" },
                    Products = new List<Product> { product1, product2 }
                };
                var order2 = new Order
                {
                    Date = DateTime.Now,
                    Customer = new Customer() { FirstName = "Alex", LastName = "Smith", Phone = 6666666, EMail = "mail66@mail.mail" },
                    Products = new List<Product> { product1, product2, prodcut3, product4 }
                };

                db.Orders.Add(order1);
                db.Orders.Add(order2);

                db.SaveChanges();
            }

            /*using (var db = new ProductContext())  //TODO Не работает, спросить
            {
                var product = db.Products.FirstOrDefault(p => p.Id == 2);
                Console.WriteLine(product.Category.Name);
            }*/
        }
    }
}
