using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    internal class Helper
    {
        private const double TOLERANCE = 10e-16;

        public static bool DoubleEquals(double a, double b)
        {
            if (Math.Abs(a - b) < TOLERANCE) return true;
            return false;
        }

        public static bool DoubleArrayEquals(double[] a, double[] b)
        {
            if(a.Length != b.Length)
            {
                return false;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (!DoubleEquals(a[i],b[i])) return false;
            }
            return true;
        }

        public static bool IsZeroArray(double[] array)
        {
 
            for (int i = 0; i < array.Length; i++)
            {
                if (!DoubleEquals(array[i], 0)) return false;
            }
            return true;
        }

        public static int numOfZerosInArray(double[] array)
        {
            int output = 0;
            foreach (double num in array)
            {
                if (DoubleEquals(0, num)) output++;
            }
            return output;
        }
    }
}
