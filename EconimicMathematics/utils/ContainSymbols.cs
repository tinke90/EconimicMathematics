using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils
{
    class ContainSymbols
    {
        private static string[] symbols = { "-", "_", ":", ";", "µ", "|", ">", "<", "\\",
        "!", "\"", "#", "¤", "%", "&", "/", "(", ")", "=", "?", "`", "´", "^", "*", "@", "£", "€",
        "$", "{", "[", "]", "}", "~", "'", "§", "½", "+", " "};

        // If input contains any numbers...
        public static bool Contains(string value)
        {
            foreach(string str in symbols)
            {
                if(value.Contains(str))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Contains(char value)
        {
            foreach(string str in symbols)
            {
                if(value.ToString().Equals(str))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
