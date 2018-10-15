using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel
{
    class ExcelExercise
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            persons.Add(new Person() { Age = 20, Name = "Alex", Surname = "Morgan", PhoneNumber = "123456" });
            persons.Add(new Person() { Age = 22, Name = "Ann", Surname = "Smith", PhoneNumber = "654321" });

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Лист1");

            worksheet.Cell("A" + 1).Value = "Имя";
            worksheet.Cell("B" + 1).Value = "Фамилия";
            worksheet.Cell("C" + 1).Value = "Возраст";
            worksheet.Cell("D" + 1).Value = "Тел. номер";

            for (int i = 0; i < persons.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = persons[i].Name;
                worksheet.Cell(i + 2, 2).Value = persons[i].Surname;
                worksheet.Cell(i + 2, 3).Value = persons[i].Age;
                worksheet.Cell(i + 2, 4).Value = persons[i].PhoneNumber;
            }

            worksheet.Columns().AdjustToContents();

            using (FileStream stream = new FileStream("out.xls", FileMode.Create, FileAccess.Write))
            {
                workbook.SaveAs(stream);
            }
        }
    }
}
