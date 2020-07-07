using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * В частотном массиве мы как бы выворачиваем массив наизнанку.
 * В частотном массиве индексы массива соответствуют его элементам.
 * Значения - это количество элементов.
 * Поэтому нужно понять, что размер частотного массива связан с диапазоном чисел, которые мы //подсчитываем
 * 
 **/

namespace _04les05
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N = 10;
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = rnd.Next(0, 100);
            }
            foreach (var item in a)
            {
                Console.WriteLine($"{item} ");
            }
            int[] mass = new int[100];
            foreach (var item in a)
            {
                mass[item]++;
            }
            int imax = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > mass[imax])
                {
                    imax = i;
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == mass[imax])
                {
                    Console.WriteLine($"\n{i}");
                }
            }

            Console.ReadKey();
        }
    }
}
