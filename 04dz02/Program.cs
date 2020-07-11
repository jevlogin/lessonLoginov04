using _04dz01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04dz02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(20, 0, 10);
            Console.WriteLine($"{array}");

            int count = StaticClass.CountPairsDivisibleByThree(array.GetArray);

            Console.WriteLine($"Количество пар элементов массива,\nв которых только одно число делится на 3 равно: {count}");

            Console.ReadKey();
        }
    }
}
