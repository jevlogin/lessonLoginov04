using System;
using System.IO;

namespace _04dz02
{
    static class StaticClass
    {
        public static int CountPairsDivisibleByThree(int[] a)
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
        public static dynamic GetArray(string fileName)
        {
            int[] a;
            if (File.Exists(fileName))
            {
                string[] ss = File.ReadAllLines(fileName);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    a[i] = int.Parse(ss[i]);
                }
                return a;
            }
            else
            {
               return "Error load file";
            }
        }

        public static void Print(int[] array2)
        {
            foreach (var el in array2)
            {
                Console.Write($"{el,4}");
            }
        }
    }

}
