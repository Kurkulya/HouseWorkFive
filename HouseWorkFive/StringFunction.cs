using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;

namespace HouseWorkFive
{
    public class StringFunction
    {
        public static int ShortestWord(string str)
        {
            if (String.IsNullOrEmpty(str))
                throw new ArgumentException();

            string[] words = Regex.Split(str, @"[\s\p{P}]");
            return words.Where((z) => z != "")
                        .Min((x) => x.Length);
        }

        //Дан массив слов.Заменить последние три символа слов, имеющих заданную длину на символ "$"
        public static string[] ReplaceLast3(string[] arr, int wordLength)
        {
            if(wordLength < 3)
                throw new ArgumentException();
            if (arr.Contains(null))
                throw new ArgumentNullException();

            string[] ret = arr.Select((z) => (z.Length == wordLength) ? z.Remove(z.Length - 3, 3) + "$" : z).ToArray();
            return ret;
        }

        public static string DeleteCopy(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            string ret = "";
            str.SelectMany((z) => ret += (ret.Contains(z) ? "" : Char.ToString(z))).ToArray();
            return ret;
        }

        public static string AddSpaces(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            List<char> checkSymbol = new List<char> { ',', '?', '!', '.' };

            for (int i = 0; i < str.Length; i++)
            {
                if (i != str.Length - 1 && checkSymbol.Contains(str[i]) && str[i + 1] != ' ')
                    str = str.Insert(i + 1, " ");
            }

            return str;
        }

        public static int WordsCount(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            string[] words = Regex.Split(str, @"[\s\p{P}]");
            return words.Where((x) => x.Length != 0).Count();
        }

        public static string MyDelete(string str, int pos, int length)
        {
            if (str == null)
                throw new ArgumentNullException();

            if (pos + length > str.Length)
                throw new ArgumentOutOfRangeException();

            return str.Remove(pos, length);
        }
    
        public static string ReverseString(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            return new string(str.Reverse().ToArray());
        }
   
        public static string DeleteLastWord(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            str = str.TrimEnd(' ');
            str = str.Remove(str.LastIndexOf(' ') + 1);
            return str.Trim();
        }
    }
}
