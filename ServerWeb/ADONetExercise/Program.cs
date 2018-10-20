﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            var dbShop = new DBShop(connectionString);

            Console.WriteLine($"Всего товаров: {dbShop.GetProductCount()}");

            //dbShop.CreateProduct("intel Core i10", 1);

            //dbShop.CreateCategory("Блоки питания");

            dbShop.UpdateProduct("Intel Core i77", 1, "[Name] = Intel Core i7");
        }
    }
}