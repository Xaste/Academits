using ClosedXML.Excel;
using System.Collections.Generic;

namespace Excel
{
    class ExcelExercise
    {
        static void Main(string[] args)
        {
            var persons = new List<Person> { new Person { Age = 20, Name = "Alex", Surname = "Morgan", PhoneNumber = "123456" },
                new Person { Age = 22, Name = "Ann", Surname = "Smith", PhoneNumber = "654321" } };

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Лист1");

                worksheet.Cell("A" + 1).Value = "Имя";
                worksheet.Cell("B" + 1).Value = "Фамилия";
                worksheet.Cell("C" + 1).Value = "Возраст";
                worksheet.Cell("D" + 1).Value = "Тел. номер";

                for (var i = 0; i < persons.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = persons[i].Name;
                    worksheet.Cell(i + 2, 2).Value = persons[i].Surname;
                    worksheet.Cell(i + 2, 3).Value = persons[i].Age;
                    worksheet.Cell(i + 2, 4).Value = persons[i].PhoneNumber;
                }

                worksheet.Columns().AdjustToContents();

                var rngTable = worksheet.Range("A1:D3");

                var rngHeaders = rngTable.Range("A1:D1");
                var rngData = rngTable.Range("A2:d3");

                rngHeaders.Style.Font.Bold = true;

                rngHeaders.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                rngHeaders.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                rngData.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                rngData.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                workbook.SaveAs("BasicTable.xlsx");
            }
        }
    }
}
