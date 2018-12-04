using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartaments
{
    class Apartaments
    {
        /// <summary>
        /// Это класс с функцией main
        /// </summary>
        /// <param name="args"></param> А это приписало Visual studio
        static void Main(string[] args)
        {
            int apartmentsOnFloor = 4;

            Console.Write("Введите число этажей: ");
            //int floorsNumber = Convert.ToInt32(Console.ReadLine());
            int buildingFloorsNumber = 1;

            Console.Write("Введите число подъездов: ");
            //int entrancesNumber = Convert.ToInt32(Console.ReadLine());
            int buildingEntrancesNumber = 1;

            Console.Write("Введите номер квартиры: ");
            //int apartment = Convert.ToInt32(Console.ReadLine());
            int apartment = 1;

            int buildingApartmentsNumber = buildingFloorsNumber * buildingEntrancesNumber * 4;

            bool isApartmentExists;
            bool isGoodData;

            //if (entrancesNumber <= 0 || floorsNumber <= 0)
            if (isGoodData = buildingEntrancesNumber <= 0 || buildingFloorsNumber <= 0)
            {
                isGoodData = false;
            }
            else
            {
                isGoodData = true;
            }

            if (apartment <= 0)
            {
                isApartmentExists = false;
            }
            else
            {
                isApartmentExists = (apartment <= buildingApartmentsNumber);
            }

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
                int sectionApartment = apartment / apartmentsOnFloor; //Считаем в скольки этажах от первого подъезда, первого этажа находится этаж с нужной квартирой
                if (apartment % apartmentsOnFloor != 0)
                {
                    sectionApartment++;
                }
                sectionApartment--;//TODO Переделать IF Сверху

                int entranceAnswer = sectionApartment / buildingFloorsNumber;

                int floorAnswer = sectionApartment - (buildingFloorsNumber * (sectionApartment / buildingFloorsNumber));

                int apartmentPosition = apartment % apartmentsOnFloor;
                /*if (apartamentCalculated == 0)
                {
                    apartamentCalculated = apartmentsOnFloor;
                }*/

                /* Если номер позиция квартиры на лестничной площадке кратна четырем
                 * получаем в остатке от деления 0, и по идеи можно было так и оставить и просто выводить при остатке равном 0 что квартира ближняя справа.
                 * Так и сделаю, идея пришла только сейчас. Раньше тут было при остатке от деления 0 присвоить значение номеру комнаты 4*/

                Console.Write($"Кв. {apartment}, Подъезд {entranceAnswer}, Этаж {floorAnswer},");
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


                int Vxodov = 5;
                int etasjei = 5;

                int apartNumb = Vxodov * etasjei * 4;
                for (int i = 1; i < apartNumb + 1; i++)
                {
                    int floorsNumber1 = etasjei;
                    int apartment1 = i;
                    int FloorsAll1 = Vxodov * etasjei;

                    int floorsCalculated1 = apartment1 / apartmentsOnFloor;
                    if (apartment1 % apartmentsOnFloor != 0)
                    {
                        floorsCalculated1++;
                    }

                    int entranceAnswer1 = floorsCalculated1 / floorsNumber1;
                    int z = floorsCalculated1 % floorsNumber1;
                    if (floorsCalculated1 % floorsNumber1 != 0)
                    {
                        entranceAnswer1++;
                    }

                    int floorAnswer1 = floorsCalculated1 % floorsNumber1;
                    if (floorAnswer1 == 0)
                    {
                        floorAnswer1 = floorsNumber1;
                    }

                    int a = 4 / 5;
                    //Console.WriteLine($"{floorsCalculated1}\t {floorsCalculated1}\t {floorsNumber1}");
                    int zz = floorsCalculated1 - floorsNumber1 * (entranceAnswer1 - 1);

                    floorsCalculated1--;
                    floorAnswer1 = floorsCalculated1 - (floorsNumber1 * (floorsCalculated1 / floorsNumber1));


                    entranceAnswer1 = floorsCalculated1/floorsNumber1;

                    Console.WriteLine($" Квартира {i}\t Площадка {floorsCalculated1}\t Всего площадок {FloorsAll1}\t Подъезд {entranceAnswer1 + 1}\t Этаж {floorAnswer1 + 1}   {zz}");
                }
                //Console.ReadLine();

                /*int CalculateAllFloors(int roomNubber, int four)
                {
                    for (int i = 1; i < 80; i++)
                    {
                        int z = i / four;
                        if (i % four != 0)
                            z++;
                        Console.WriteLine($" Этаж {z}   Подъезд ");
                    }

                    return 1;
                }
                int zzz = CalculateAllFloors(5, 4);*/
                Console.ReadLine();
            }
        }
    }
}
