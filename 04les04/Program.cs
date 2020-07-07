using System;
using System.IO;

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
                using (StreamReader sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        int N = int.Parse(sr.ReadLine());
                        a = new int[N];
                        Console.WriteLine(a);
                        for (int i = 0; i < N; i++)
                        {
                            a[i] = int.Parse(sr.ReadLine());
                        }
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
            foreach (var el in a)
            {
                Console.WriteLine($"{a, 4}");
            }
        }
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray("data.txt");
            //a.Print();
            Console.WriteLine($"\nMax: {a.Max}");
            Console.WriteLine($"Min: {a.Min}");
            Console.WriteLine($"Middle: {a.Sum/a.Length}");
            a.BubleSort();
            a.Print("Отсортированный массив");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
