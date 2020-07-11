﻿using System;
using System.IO;
using System.Linq;


/**
 * 
 * Задача 6
 * Разработать класс для работы с одномерным массивом. 
 * Создать конструктор для заполнения массива случайными 
 * числами и конструктор для заполнения массива из файла. 
 * Создать свойство, возвращающее максимальный элемент. 
 * Реализовать индексируемое свойство.
 * 
 * */


namespace _04les08
{
    class CoolArray
    {
        private int[] a;
        Random rnd = new Random();

        public CoolArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 101);
            }
        }

        public CoolArray(string filename)
        {
            if (File.Exists(filename))
            {
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    a[i] = int.Parse(ss[i]);
                }
            }
            else
            {
                Console.WriteLine("Error load file");
            }
        }
        public int Max
        {
            get
            {
                return a.Max();
            }
        }
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public void Print()
        {
            foreach (int el in a)
            {
                Console.WriteLine($"{el,4}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CoolArray array = new CoolArray(5);
            array.Print();
            Console.WriteLine();
            Console.WriteLine($"Максимальный элемент: {array.Max}");
            Console.WriteLine($"array[3]: {array[3]}");

            Console.ReadKey();
        }
    }
}
