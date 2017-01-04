using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public class NumberToWords
    {
        public static string getExpression(string number, string currency)
        {
            var result = string.Empty;
            var aa = decimal.Parse(number);
            var nn = (int)aa;
            try
            {
                var dp = number.Split('.')[1];
                result = string.Format("Only {0} And {1}/100 {2}", getWords(nn), getDecimal(int.Parse(dp)).ToString(), currency);
            }
            catch (Exception)
            {
                result = string.Format("Only {0} {1}", getWords(nn), currency);
                ;
            }
            return result;
        }

        private static string getDecimal(int i)
        {
            var n = i.ToString();
            if (n.Length > 2)
            {
                if (int.Parse(n.Substring(2, 1)) >= 5)
                {
                    n = (int.Parse(n.Substring(0, 2)) + 1).ToString();
                }
                else
                {
                    n = (int.Parse(n.Substring(0, 2))).ToString();
                }
            }
            return n.ToString();
        }

        private static string getWords(int number)
        {
            if (number == 0)
            {
                return "Zero";
            }
            if (number < 0)
            {
                return "Minus " + getWords(Math.Abs(number));
            }
            var words = string.Empty;

            if ((number / 1000000) > 0)
            {
                words += getWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += getWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += getWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != string.Empty)
                {
                    words += "And ";
                }
                var unitsMap = new [] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                    "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new [] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty",
                    "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                {
                    words += unitsMap[number];
                }
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += "-" + unitsMap[number % 10];
                    }
                }
            }

            return words;
        }
    }
}
