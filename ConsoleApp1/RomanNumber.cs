using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        internal class RomanNumber : ICloneable, IComparable
        {

            private ushort _number;
            private static int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            private static string[] roman = new string[]
                { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            public RomanNumber(ushort n)
            {
                if (n <= 0) throw new RomanNumberException($"Chislo {n} <= 0");
                else this._number = n;
            }
            public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
            {
                int num = n1._number + n2._number;
                if (num <= 0) throw new RomanNumberException("Ne udalos` summirovat`  chisla");
                else
                {
                    RomanNumber result = new((ushort)num);
                    return result;
                }
            }
            public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
            {
                int num = n1._number - n2._number;
                if (num <= 0) throw new RomanNumberException("Rezultat vichitanya <= 0");
                else
                {
                    RomanNumber result = new((ushort)num);
                    return result;
                }
            }
            public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
            {
                int num = n1._number * n2._number;
                if (num <= 0) throw new RomanNumberException("Ne udalos` umnozhit` 2 chisla");
                else
                {
                    RomanNumber result = new((ushort)num);
                    return result;
                }
            }
            public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
            {

                if (n2._number == 0) throw new RomanNumberException("Error delenie");
                else
                {
                    int num = n1._number / n2._number;
                    if (num == 0) throw new RomanNumberException("Error delenie");
                    else
                    {
                        RomanNumber result = new((ushort)num);
                        return result;
                    }
                }
            }
            public override string ToString()
            {
                int tmp = _number;
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < 13; i++)
                {
                    while (tmp >= values[i])
                    {
                        tmp -= (ushort)values[i];
                        result.Append(roman[i]);
                    }
                }
                if (result.ToString() == "")
                    throw new RomanNumberException("Perevod nevozmojen");
                else
                    return result.ToString();

            }

            public object Clone()
            {
                return new RomanNumber(_number);
            }

            public int CompareTo(object obj)
            {
                if (obj is RomanNumber roman)
                    return _number.CompareTo(roman._number);
                else
                    throw new RomanNumberException("object is not a RomanNumber");
            }

        }
}
