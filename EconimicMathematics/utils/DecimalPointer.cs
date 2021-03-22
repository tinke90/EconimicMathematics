using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils
{
    class DecimalPointer
    {
        public static string Convert(string decimalPointer)
        {
            if(decimalPointer.Contains(","))
            {
                string[] split = decimalPointer.Split(',');
                return split[0] + "." + split[1];
            }

            return decimalPointer;
        }
    }
}
