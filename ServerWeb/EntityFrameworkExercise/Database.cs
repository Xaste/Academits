using EntityFrameworkExercise.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExercise
{
    static class Database
    {
        public static void CreateDatabase()
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
                var product3 = new Product
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
                    PurchaseDate = DateTime.Now,
                    Customer = new Customer() { FirstName = "Vlad", LastName = "Martyn", Phone = 7777777, EMail = "mail@mail.mail" },
                    Products = new List<Product> { product1, product2, product3 }
                };
                var order2 = new Order
                {
                    PurchaseDate = DateTime.Now,
                    Customer = new Customer() { FirstName = "Alex", LastName = "Smith", Phone = 6666666, EMail = "mail66@mail.mail" },
                    Products = new List<Product> { product1, product2, product3, product4 }
                };
                var order3 = new Order
                {
                    PurchaseDate = DateTime.Now,
                    Customer = new Customer() { FirstName = "Alex", LastName = "Black", Phone = 6666661, EMail = "mail61@mail.mail" },
                    Products = new List<Product> { product3 }
                };

                db.Orders.Add(order1);
                db.Orders.Add(order2);
                db.Orders.Add(order3);

                db.SaveChanges();
            }
        }

        public static void AddInDataBase()
        {
            using (var db = new ProductContext())
            {
                var category = new Category { Name = "Клавиатуры" };
                db.Categories.Add(category);
                db.SaveChanges();
            }

        }

        public static void ChangeInDataBase()
        {
            using (var db = new ProductContext())
            {
                var category = db.Categories.FirstOrDefault(c => c.Name == "Клавиатуры");
                category.Name = "Мышки";
                db.SaveChanges();
            }
        }

        public static void DeleteInDataBase()
        {
            using (var db = new ProductContext())
            {
                //var id = db.Categories.FirstOrDefault(c => c.Name == "Мышки").Id;

                var category = db.Categories.FirstOrDefault(c => c.Name == "Мышки");
                db.Entry(category).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public static string FindMostBuyableProduct()
        {
            using (var db = new ProductContext())
            {
                return db.Products.OrderByDescending(p => p.Orders.Count)
                    .First().Name;
            }
        }

        public static void PrintCustomersExpenses()
        {
            Console.WriteLine();
            Console.WriteLine("Траты клиентов:");

            using (var db = new ProductContext())
            {
                var customerList = db.Customers.ToList();

                foreach (var customer in customerList)
                {
                    Console.Write($"{customer.FirstName} {customer.MiddleName} {customer.LastName} : ");

                    var orderPrice = db.Orders
                        .Where(ord => ord.CustomerId == customer.Id)
                        .Select(x => x.Products)
                        .ToList()
                        .FirstOrDefault()
                        .Sum(a => a.Price);

                    Console.WriteLine(orderPrice);
                }
            }
        }

        /*public static void PrintCategoriesStatistic()
        {
            Console.WriteLine();
            Console.WriteLine("Количество проданных товаров по категориям:");

            using (var db = new ProductContext())
            {
                var categoryList = db.Categories.ToList();

                var ProductList = db.Products.ToList();

                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                foreach (var product in ProductList)
                {
                    var k1 = db.Products.Where(x => x.Id == 1).ToList();
                    var k2 = db.Categories.Where(x => x.Id == 1).ToList();

                    var z = db.Categories.Where(x => x.Id == 1)
                        .Select(x => x.Products).ToList();


                    var k = db.Products
                        .Where(x => x.Name == product.Name)
                        .Select(x => x.Orders)
                        .FirstOrDefault().Count;
                    dictionary.Add(product.Name, k);
                }



                foreach (var category in categoryList)
                {
                    Console.Write($"{category.Name} :");

                    //var productCount = db.Categories.Select(a => a.Products).ToList().FirstOrDefault();
                    var tt = db.Orders.Select(x => x.Products).ToList();

                    var kk = db.Products.Select(x => x.Orders).ToList();

                    var value = db.Products.Select(c => c.Orders).ToList();

                    //var n = db.Products.ToDictionary(x => x.Name, x => x. x.Orders.FirstOrDefault().ToString());


                    var t = db.Orders
                        .Select(x => x.Products)
                        .FirstOrDefault()
                        .Where(x => x.Category == category)
                        .Count();
                    Console.WriteLine(t);
                }
            }
        }*/
    }
}
