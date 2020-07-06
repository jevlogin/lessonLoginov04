using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonLoginov04
{
    class MyArray
    {
        private int[] a;

        public int Length { get; set; }

        public MyArray(int n)
        {
            a = new int[n];
            Length = n;
        }
        public int Get(int i)
        {
            return a[i];
        }
        public void Set(int i, int value)
        {
            a[i] = value;
        }

        // либо создаем индексатор
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(10);
            for (int i = 0; i < array.Length; i++)
            {
                array.Set(i, i * 10);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 20;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
