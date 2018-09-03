using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExercise
{
    class ReflectionExercise
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите имя сборки:");
            var assemblyName = Console.ReadLine();

            Console.WriteLine("Введите имя класса:");
            var className = Console.ReadLine();*/


            var assembly = Assembly.LoadFrom("Vector.exe");
            //var assembly = Assembly.Load(assemblyName);

            Type type = assembly.GetType("VectorExercise.Vector");
            ConstructorInfo ctor = type.GetConstructor(new Type[] { typeof(int) });

            var x = ctor.Invoke(new object[] { 10 });
        }
    }
}
