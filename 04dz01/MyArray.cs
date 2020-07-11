using System;

namespace _04dz01
{
    class MyArray
    {
        private int[] a;
        private const int MinA = -10_000;
        private const int MaxA = 10_000;

        Random rnd = new Random();

        public MyArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(MinA, MaxA);
            }
        }

        public MyArray(int n, int minA, int maxA)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(minA, maxA);
            }
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    s += $"{a[i],6}";
                }
                else
                {
                    s += $"{a[i],6}\n";
                }
            }
            return s;
        }

        public void Print()
        {
            foreach (var el in a)
            {
                Console.WriteLine(el);
            }
        }

        public int CountPairsDivisibleByThree()
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0 && a[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
