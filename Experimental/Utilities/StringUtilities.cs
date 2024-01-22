using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Utilities
{
    public static class StringUtilities
    {
        private static char[] _ws = new char[] { ' ', '\n', '\r', '\t', ';', '@' }; 

        public static string Normalize(this string s)
        {
            return s.Trim().ToLower();
        }

        public static List<string> SplitOnWhiteSpace(this string s)
        {
            var words = s.Split(_ws, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            return new List<string>(words);
        }

        public static string Concatenate(this List<string> list, string delim = ", ")
        {
            var sb = new StringBuilder();
            var first = true;
            foreach (var word in list)
            {
                if (first)
                {
                    sb.Append(word);
                    first = false;
                } else
                {
                    sb.Append(delim);
                    sb.Append(word);
                }
            }
            return sb.ToString();
        }

    }
}
