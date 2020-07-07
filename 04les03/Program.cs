using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04les03
{
    class MyArray
    {
        private int[] a;
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = el;
            }
        }

        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(min, max);
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                }
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public override string ToString()
        {
            string s = string.Empty;
            foreach (var item in a)
            {
                s = s + item + " ";
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, 0, 100);
            Console.WriteLine($"Массив равен: {a}");
            Console.WriteLine($"Максимальное число из массива = {a.Max}");
            Console.WriteLine($"Минимальное число из массива = {a.Min}");
            Console.WriteLine($"Количество положительных чисел = {a.CountPositiv}");

            Console.ReadKey();
        }
    }
}
