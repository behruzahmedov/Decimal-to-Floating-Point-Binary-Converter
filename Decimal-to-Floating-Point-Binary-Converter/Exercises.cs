using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Go through the number, using the division by 2 method to turn into binary
//Use x2 method for the fractional part
//

namespace Decimal_to_Floating_Point_Binary_Converter
{
    public static class Exercises
    {
        public static double DecToBinWholeNumber(double num)
        {
            string str = string.Empty;
            num = Math.Floor(num);
            while (num > 0)
            {
                str = str.Insert(0, Convert.ToString(num % 2));
                num /= 2;
                num = Math.Floor(num);
            }
            //Make sure the string has length 4 so that last 4 bits can be taken
            while (str.Length < 4)
            {
                str = str.Insert(0, "0");
            }
            str = str.Substring(str.Length - 4);
            return Convert.ToDouble(str);
        }

        public static double DecToBinFractional(double num)
        {
            string str = string.Empty;
            num = num - Math.Floor(num);
            for (int i = 0; i < 5; i++)
            {
                num *= 2;
                str += Convert.ToString(num)[0];
                num = num - Math.Floor(num);
            }
            if (str[-1] == '0')
            {
                str = str.Substring(0, str.Length - 1);
            }
            else
            {

            }
            return Convert.ToDouble(str);
        }
        public static string DecToBinFixed(double num)
        {
            return "code";
        }
    }
}