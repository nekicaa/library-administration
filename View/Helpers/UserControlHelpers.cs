using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Helpers
{
    public class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool IntValidation(TextBox txt)
        {
            if (!int.TryParse(txt.Text, out int _))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        // dodajem nove validacije koje koristim

        public static bool DateTimeValidation(TextBox txt)
        {
            if (!DateTime.TryParse(txt.Text, out DateTime result))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool ComboBoxValidation(ComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                cmb.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                cmb.BackColor = Color.White;
                return true;
            }
        }

        public static bool AllNumberValidation(TextBox text)
        {
            if (text.Text.Any(s => char.IsLetter(s)))
            {
                text.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                text.BackColor = Color.White;
                return true;
            }
        }
    }
}
