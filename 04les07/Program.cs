using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Задача 5. Задача на матрицу 
 * Дан прямоугольный массив целых положительных чисел N х M, 
 * заполненный случайными числами. Описать на русском языке 
 * или на одном из языков программирования алгоритм поиска 
 * строки с наименьшей суммой элементов. Вывести на печать
 * номер строки и сумму её элементов. Если таких строк несколько, 
 * вывести информацию о каждой строке.
 * 
 * */


namespace _04les07
{
    class Matrix
    {
        int[,] a;
        int[] Rows;
        public Matrix(int n, int m)
        {
            a = new int[n, m];
            Random rnd = new Random();
            Rows = new int[n];
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(0, 10);
                    s += a[i, j];
                }
                Rows[i] = s;
            }
        }
        public void Print()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        public int Search(out int count)
        {
            int min = int.MaxValue;
            count = 0;
            foreach (int e in Rows)
            {
                if (e < min)
                {
                    min = e;
                }
            }
            foreach (int e in Rows)
            {
                if (e==min)
                {
                    count++;
                }
            }
            return min;
        }
        public void SearchRows()
        {
            int countRow;
            int min = Search(out countRow);
            for (int i = 0; i < Rows.Length; i++)
            {
                if (Rows[i] == min)
                {
                    Console.WriteLine($"\n{i} {Rows[i]}");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix(5, 5);
            a.Print();
            a.SearchRows();

            Console.ReadKey();
        }
    }
}
