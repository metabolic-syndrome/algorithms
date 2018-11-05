using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruk_algorithms_01_11
{
    class Search
    // Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный массив.
    {
        public static int Bin(int[] m, int left, int right, int item)
        {
            if (left > right)
                return -1;
            int found = left + (right - left) / 2;
            if (m[found] > item)
                return Bin(m, left, found - 1, item);
            else if (m[found] < item)
                return Bin(m, found + 1, right, item);
            else
                return m[found];
        }
    }

}