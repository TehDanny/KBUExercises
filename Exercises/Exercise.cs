using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercise
    {
        public static int Middle(int x, int y, int z)
        {
            if (x > y && x < z || x < y && x > z)
                return x;
            if (y > x && y < z || y < x && y > z)
                return y;
            if (z > x && z < y || z < x && z > y)
                return z;
            return 0;
        }

        public int Middle2(int x, int y, int z)
        {
            int[] numArr = { x, y, z };
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] != numArr.Min() && numArr[i] != numArr.Max())
                    return numArr[i];
            }
            return 0;
        }

        /* // recursiv
        public int Middle3(int x, int y, int z)
        {
            int middle = 0;
            if (middle)
                return middle;
            else
                return Middle3();
        }
        */

        public static int Middle4(int x, int y, int z)
        {
            int[] numArr = { x, y, z };
            return Median(numArr);
        }

        public static int Middle4(int a, int b, int c, int d, int e, int f, int g, int h, int i)
        {
            int[] numArr = { a, b, c, d, e, f, g, h, i };
            return Median(numArr);
        }

        public static int Median(int[] numArr)
        {
            int middleIndex = (numArr.Length) / 2;
            BubbleSort(numArr);
            int middleNumber = numArr[middleIndex];

            return middleNumber;
        }

        private static int[] BubbleSort(int[] numArr)
        {
            bool hasSwapped;
            int tempValue;

            do
            {
                hasSwapped = false;

                for (int i = 0; i < numArr.Length - 1; i++)
                {
                    if (numArr[i] > numArr[i + 1])
                    {
                        tempValue = numArr[i];
                        numArr[i] = numArr[i + 1];
                        numArr[i + 1] = tempValue;
                        hasSwapped = true;
                    }
                }
            } while (hasSwapped == true);
            return numArr;
        }

        public static bool ValueExists()
        {
            double x = 3;
            int[] t = { 1, 2, 3 };
            for (int i = 0; i < t.Length; i++)
            {
                if (x.Equals(t[i]))
                    return true;
            }
            return false;
        }
    }
}
