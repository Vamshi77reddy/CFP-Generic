using System;
using System.Collections.Generic;
using System.Text;

namespace MaxandMinUsingGenerics
{
    internal class Minumum
    {
        public void FindMinimum(int number1, int number2, int number3)
        {
            int minimum = number1;
            if (number2 < minimum)
            {
                minimum = number2;
            }
            if (number3 < minimum)
            {
                minimum = number3;
            }
            Console.WriteLine($"The Minimum of the given three numbers {number1}, {number2} and {number3} is: {minimum}");
        }

        public void FindMinimum2(double number1, double number2, double number3)
        {
            double minimum = number1;
            if (number2 < minimum)
            {
                minimum = number2;
            }
            if (number3 < minimum)
            {
                minimum = number3;
            }
            Console.WriteLine($"The Minimum of the given three numbers {number1}, {number2} and {number3} is: {minimum}");
        }

        public void FindMinimum3(string string1, string string2, string string3)
        {
            string minimum = string1;
            if (string2.CompareTo(minimum) < 0)
            {
                minimum = string2;
            }
            if (string3.CompareTo(minimum) < 0)
            {
                minimum = string3;
            }
            Console.WriteLine($"The Minimum of the given three strings {string1}, {string2} and {string3} is: {minimum}");
        }
    }
}
