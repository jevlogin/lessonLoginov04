using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * Дана последовательность целых чисел, записанная в текстовый файл. 
 * Требуется считать данные из файла в массив, найти 
 * среднее арифметическое элементов и вывести минимальный 
 * и максимальный элементы массива на экран. Отсортировать массив.
 * 
 **/


namespace _04les04
{
    class MyArray
    {
        int[] a;
        public MyArray(string filename)
        {
            const string path = "..\\..\\data.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int N = int.Parse(sr.ReadLine());
                    a = new int[N];
                    for (int i = 0; i < N; i++)
                    {
                        a[i] = int.Parse(sr.ReadLine());
                    }
                    sr.Close();
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public int Length
        {
            get
            {
                return a.Length;
            }
        }
        public double Sum
        {
            get
            {
                double sum = 0;
                foreach (var item in a)
                {
                    sum += item;
                }
                return sum;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 0; i < Length; i++)
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
                for (int i = 0; i < Length; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                }
                return min;
            }
        }

        public void BubleSort()
        {
            // Сортируем методом пузырька
            for (int i = 0; i < Length; i++)
            {
                for (int k = 0; i < Length - 1; i++)
                {
                    if (a[k] > a[k +1])
                    {
                        int t = a[k];
                        a[k] = a[k + 1];
                        a[k + 1] = t;
                    }
                }
            }
        }
        public void Print()
        {
            foreach (var item in a)
            {
                Console.WriteLine($"{item,4}");
            }
        }
        public void Print(string msg)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
