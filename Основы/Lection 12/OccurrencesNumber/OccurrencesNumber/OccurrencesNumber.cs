using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesNumber
{
    class OccurrencesNumber
    {
        static void Main(string[] args)
        {


            using (StreamReader reader = new StreamReader("input.txt"))
            {
                int countAnswer = 0;
                string findString = "asd";

                while (true)
                {
                    var str = reader.ReadLine();

                    if (str == null)
                    {
                        break;
                    }

                    countAnswer += GetEntranceCount(findString, str);
                }

                Console.WriteLine(countAnswer);
            }

        }

        public static int GetEntranceCount(string findString, string baseString)
        {
            int count = 0;
            int index = -1;
            string str = baseString.ToLower();
            string targetstring = findString.ToLower();

            while (true)
            {
                index = str.IndexOf(targetstring, index + 1);

                if (index == -1)
                {
                    break;
                }

                ++count;
            }

            return count;
        }
    }
}
