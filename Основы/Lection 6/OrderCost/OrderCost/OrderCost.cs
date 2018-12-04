using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCost
{
    class OrderCost
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стомиость товара первого типа: ");
            double productACost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество товара первого типа: ");
            int productACount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите стоимость товара второго типа: ");
            double productBCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество товара второго типа: ");
            int productBCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Стоимость со скидкой(если есть): {GetOrderPriceFinal(productACount, productACost, productBCount, productBCost)}");
        }

        public static double GetOrderPriceFinal(int productACount, double productACost, int productBCount, double productBCost)
        {
            double orderPrice = productACost * productACount + productBCost * productBCount;
            int orderCount = productACount + productBCount;
            const int minimumOrderCountForDiscount = 10;
            const int minimumOrderPriceForDiscount = 1000;
            const int percentConvertRate = 100;

            bool isFirstTypeDiscount = orderCount >= minimumOrderCountForDiscount;
            bool isSecondTypeDiscount = orderPrice >= minimumOrderPriceForDiscount;

            double discount;
            if (isFirstTypeDiscount && isSecondTypeDiscount)
            {
                discount = 10;
            }
            else if (isFirstTypeDiscount || isSecondTypeDiscount)
            {
                discount = 5;
            }
            else
            {
                discount = 0;
            }
            return orderPrice - orderPrice * (discount / percentConvertRate);
        }
    }
}
