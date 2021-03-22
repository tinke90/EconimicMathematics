using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconimicMathematics.utils
{
    class Textfield
    {
        public static void LoadClearClickListener(TextBox field)
        {
            field.Click += (sender, e) => 
            {
                if(ContainsChars.Contains(field.Text) || ContainSymbols.Contains(field.Text))
                {
                    field.Clear();
                }
            };
        }

        public static void LoadDoubleTabClearClickListener(TextBox field)
        {
            field.DoubleClick += (sender, e) =>
            {
                field.Clear();
            };
        }

        public static void LoadDoubleTabClearClickListener(TextBox field, string description)
        {
            field.DoubleClick += (sender, e) =>
            {
                field.Text = description;
            };
        }
    }
}
