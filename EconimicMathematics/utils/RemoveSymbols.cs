using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils
{
    class RemoveSymbols
    {
        public static string Remove(string input)
        {
            if(input.Contains("%"))
            {
                input = input.Replace("%","");
            }

            if(input.Contains("€"))
            {
                input = input.Replace("€", "");
            }

            if(input.Contains("$"))
            {
                input = input.Replace("$", "");
            }

            if(input.Contains(" "))
            {
                input = input.Replace(" ", "");
            }

            return input;
        }
    }
}
