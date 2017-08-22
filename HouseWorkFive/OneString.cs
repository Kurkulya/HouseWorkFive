using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWorkFive
{
    class OneString
    {
        public static void PrintAlphabetUpper()
        {
            string s = "";
            for (char i = 'A'; i <= 'Z'; i++)
            {
                s += i + " ";
            }
            Console.WriteLine(s);
        }
        public static void PrintAlphabetReverse()
        {
            string s = "";
            for (char i = 'z'; i >= 'a'; i--)
            {
                s += i + " ";
            }
            Console.WriteLine(s);
        }

        public static void PrintAlphabetRus()
        {
            string s = "";
            for (char i = (char)1072; i < 1072 + 32; i++)
            {
                s += i + " ";
            }
            Console.WriteLine(s);
        }

        public static void PrintDigits()
        {
            string s = "";
            for (char i = '0'; i <= '9'; i++)
            {
                s += i + " ";
            }
            Console.WriteLine(s);
        }

        public static void PrintASCII()
        {
            string s = "";
            for (char i = (char)0; i < 256; i++)
            {
                s += i + " ";
            }
            Console.WriteLine(s);
        }
    }
}

