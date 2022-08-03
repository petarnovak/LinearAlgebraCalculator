using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsUI
{
    class NumberFormatter
    {
        private static int decimalsToRound = 10;
        public int DecimalsToround
        {
            get => decimalsToRound;
            set
            {
                if (value >= 0)
                    decimalsToRound = value;
            }
        }
        public static string doubleFormat(double d)
        {

            string output = d.ToString("F" + decimalsToRound);

            while (output.EndsWith('0'))
            {
                output = output.Remove(output.Length - 1);
            }
            if (output.EndsWith(','))
            {
                output = output.Remove(output.Length - 1);
            }
            if (output.Equals("-0"))
            {
                output = "0";
            }

            return output;
        }
    }
}
