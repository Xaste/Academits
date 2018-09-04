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

            var componentsInfo = x.GetType().GetField("vectorComponents", BindingFlags.Instance | BindingFlags.NonPublic);
            var componentsData = (double[])componentsInfo.GetValue(x);

            for (int i = 0; i < componentsData.Length; i++)
            {
                componentsData[i]++;
            }

            componentsInfo.SetValue(x, componentsData);

            var m = type.GetMethod("ScalarMultiplication", new Type[] { typeof(double) });

            var res = m.Invoke(x, new object[] { 2 });
        }
    }
}
