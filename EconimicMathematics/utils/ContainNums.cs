using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils
{
    class ContainNums
    {
        private static string[] nums = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        // If input contains any numbers...
        public static bool Contains(string value)
        {
            foreach(string str in nums)
            {
                if(value.Contains(str))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
