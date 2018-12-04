using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments
{
    class Apartments
    {
        /// <summary>
        /// Это класс с функцией main
        /// </summary>
        /// <param name="args">Видимо аргументы</param> А это приписало Visual studio
        static void Main(string[] args)
        {
            int apartmentsOnFloor = 4;

            Console.Write("Введите число этажей: ");
            int buildingFloorsNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число подъездов: ");
            int buildingEntrancesNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер квартиры: ");
            int apartment = Convert.ToInt32(Console.ReadLine());

            int buildingApartmentsNumber = buildingFloorsNumber * buildingEntrancesNumber * apartmentsOnFloor;

            bool isApartmentExists = apartment > 0 && apartment <= buildingApartmentsNumber;
            bool isGoodData = buildingEntrancesNumber > 0 && buildingFloorsNumber > 0;

            if (!isGoodData)
            {
                Console.WriteLine("Введены некорректные данные: количество этажей или подъездов");
                Console.ReadLine();
            }
            else if (!isApartmentExists)
            {
                Console.WriteLine($"Квартиры с номером {apartment} нет в этом доме. Всего возможно квартир: {buildingApartmentsNumber}");
                Console.ReadLine();
            }
            else
            {
                int sectionApartment = (apartment - 1) / apartmentsOnFloor; //Считаем в скольки этажах от первого подъезда, первого этажа находится этаж с нужной квартирой. Отсчет с 0

                int entranceAnswer = sectionApartment / buildingFloorsNumber + 1;//TODO Пример todo

                int floorAnswer = sectionApartment - (buildingFloorsNumber * (sectionApartment / buildingFloorsNumber)) + 1;

                int apartmentPosition = apartment % apartmentsOnFloor;

                Console.Write($"Кв. {apartment}, Подъезд {entranceAnswer}, Этаж {floorAnswer}, ");
                switch (apartmentPosition)
                {
                    case 1:
                        Console.WriteLine("Ближняя слева");
                        break;
                    case 2:
                        Console.WriteLine("Дальняя слева");
                        break;
                    case 3:
                        Console.WriteLine("Дальняя справа");
                        break;
                    case 0:
                        Console.WriteLine("Ближняя справа");
                        break;
                    default:
                        Console.WriteLine("Что-то пошло не так...");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
