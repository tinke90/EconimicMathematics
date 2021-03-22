using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils
{
    class ContainsChars
    {
        private static string[] characters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
        "k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","å","ä","ö"};
        

        // If input contains any numbers...
        public static bool Contains(string value)
        {
            foreach(string str in characters)
            {
                if(value.Contains(str) || value.Contains(str.ToUpper()))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Contains(char value)
        {
            foreach(string str in characters)
            {
                if(value.ToString().Equals(str) || value.ToString().Equals(str.ToString().ToUpper()))
                {
                    return true;
                }
            }

            return false;
        }

        public static string Remove(string value)
        {
            string result = "";

            char[] split = value.ToCharArray();

            for(int i = 0; i < split.Length; i++)
            {
                
                if(!Contains(split[i]))
                {

                    result += split[i];
                }
            }

            return result;
        }
    }
}
