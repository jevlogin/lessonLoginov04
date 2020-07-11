using System;

namespace _04dz02
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "data.txt";

            MyArray array = new MyArray(20, 0, 10);
            Console.WriteLine($"{array}");

            int count = StaticClass.CountPairsDivisibleByThree(array.GetArray);
            Console.WriteLine($"Количество пар элементов массива,\nв которых только одно число делится на 3 равно: {count}");

            var array2 = (int[])StaticClass.GetArray(filename);

            if (array2.GetType().Equals(typeof(int[])))
            {
                Console.WriteLine($"Полученный массив из файла");
                StaticClass.Print(array2);
            }
            else
            {
                Console.WriteLine($"Вщзникла ошибка при считвании файла: {array2}");
            }
            Console.ReadKey();
        }
    }
}

