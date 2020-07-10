using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 
 * Задача 4. Класс «Мой двумерный массив» 
 * Разработать класс для работы с двумерным массивом. 
 * Сделать методы поиска среднего значения, максимального элемента 
 * массива, минимального элемента массива, 
 * подсчета количества положительных элементов массива,
 * вывода массива на экран и метод, возвращающий массив в виде строки.
 * 
 * */

namespace _04les06
{
    class MyArrayTwoDim
    {
        int[,] a;
        public MyArrayTwoDim(int n, int el)
        {
            a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = el;
                }
            }
        }
        public MyArrayTwoDim(int n, int min, int max)
        {
            a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(min, max);
                }
            }
        }
        public int Min
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min)
                        {
                            min = a[i, j];
                        }
                    }
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max)
                        {
                            max = a[i, j];
                        }
                    }
                }
                return max;
            }
        }
        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(0); j++)
                    {
                        if (a[i, j] > 0) count++;
                        {

                        }
                    }
                }
                return count;
            }
        }
        public double Average
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        sum += a[i, j];
                    }
                }
                return sum / a.GetLength(0) / a.GetLength(1);
            }
        }
        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s += $"{a[i, j],4}";
                }
                s += "\n";
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayTwoDim a = new MyArrayTwoDim(10, 0, 100);
            Console.WriteLine(a.ToString());
            Console.WriteLine($"Минимальный элемент: {a.Min}");
            Console.WriteLine($"Максимальный элемент: {a.Max}");
            Console.WriteLine($"Среднее значение элементов: {a.Average}");

            Console.ReadKey();
        }
    }
}
