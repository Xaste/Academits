using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileToUpper
{
    class TextFileToUpper
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                using (StreamReader reader = new StreamReader("input.txt"))
                {
                    string currentLine;
                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(currentLine.ToUpper());
                    }
                }
            }
        }
    }
}
