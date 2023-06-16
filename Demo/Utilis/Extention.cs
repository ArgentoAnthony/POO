using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Utilis
{
    public static class Extention
    {
        public static string SuperCamelCase(this string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += i % 2 == 0 ? str[i].ToString().ToUpper() : Char.ToLower(str[i]);
            }

            return result;

        }
        public static string SuperCamelCase(this string str, string s)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += i % 2 == 0 ? str[i].ToString().ToUpper() : Char.ToLower(str[i]);
            }

            return result + s;

        }
        public static string Trim (this string str, bool isSuperTrim)
        {
            if (isSuperTrim)
            {
                return str.Replace(" ","");
            }
            return str.Trim();
        }
    }
}
