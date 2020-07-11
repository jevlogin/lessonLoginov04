using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
