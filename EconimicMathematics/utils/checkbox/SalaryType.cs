using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconimicMathematics.utils.checkbox
{
    class SalaryType
    {
        public static void LoadCheckboxSwitch(CheckBox checkbox, string option_1, string option_2)
        {
            checkbox.Click += (sender, e) =>
            {
                Switch(checkbox, option_1, option_2);
            };
        }

        private static void Switch(CheckBox checkbox, string option_1, string option_2)
        {
            if(checkbox.Checked)
            {
                checkbox.Text = option_1;
            }
            else
            {
                checkbox.Text = option_2;
            }
        }
    }
}
