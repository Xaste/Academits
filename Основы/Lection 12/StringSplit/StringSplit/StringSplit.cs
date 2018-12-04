using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class StringSplit
    {
        static void Main(string[] args)
        {
            string st = "1, 2, 3, 4, 5";

            string[] numbers = st.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            foreach (var e in numbers)
            {
                sum += Convert.ToInt32(e);
            }
            Console.WriteLine(sum);
        }
    }
}
