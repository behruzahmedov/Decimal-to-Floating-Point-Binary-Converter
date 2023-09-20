﻿using System;
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
        public static string DecToBinWholeNumber(double num)
        {
            string str = string.Empty;
            bool negative = false;
            if (num < 0)
            {
                negative = true;
            }
            num = Math.Floor(num);
            while (Math.Abs(num) > 0) { 
                str = str.Insert(0, Convert.ToString(Math.Abs(num) % 2));
                if (negative == true && Math.Abs(num) % 2 == 1 && num != -1)
                {
                    num = num/2 - 0.5;
                }
                else
                {
                    num = (double)((int)num / 2);
                }
            }
            if (negative == false)
            {
                str = str.Insert(0, "0");
            }
            return str;
        }

        public static string DecToBinFractional(double num)
        {
            string str = string.Empty;
            bool negative = false;
            if (num < 0)
            {
                negative = true;
            }
            num = Math.Abs(num) - Math.Floor(Math.Abs(num));
            if (negative)
            {
                num = 1 - num;
            }
            for (int i = 0; i < 5; i++)
            {
                num *= 2;
                str += Convert.ToString(num)[0];
                num -= Math.Floor(num);
            }
            return str;
        }
        public static string DecToBinFixed(double num)
        {
            string bin = DecToBinWholeNumber(num) + '·' + DecToBinFractional(num);
            return bin;
        }
    }
}