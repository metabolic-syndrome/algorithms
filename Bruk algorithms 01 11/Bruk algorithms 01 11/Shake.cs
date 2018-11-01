using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruk_algorithms_01_11

// Реализовать шейкерную сортировку.
{
    class Shake
    {
        public static void ArrSort(int[] name)
        {
            int b = 0;
            int left = 0;
            int right = name.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (name[i] > name[i + 1])
                    {
                        b = name[i];
                        name[i] = name[i + 1];
                        name[i + 1] = b;
                        b = i;
                    }
                }
                right = b;
                if (left >= right) break;
                for (int i = right; i > left; i--)
                {
                    if (name[i - 1] > name[i])
                    {
                        b = name[i];
                        name[i] = name[i - 1];
                        name[i - 1] = b;
                        b = i;
                    }
                }
                left = b;
            }
        }
    }
}
