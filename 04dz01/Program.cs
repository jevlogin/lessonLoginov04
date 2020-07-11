using System;

namespace _04dz01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(20);
            Console.WriteLine(array);
            Console.WriteLine($"Количество пар элементов массива,\nв которых только одно число делится на 3 равно: {array.CountPairsDivisibleByThree()}");

            Console.ReadKey();
        }
    }
}
