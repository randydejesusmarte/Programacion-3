using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_3.Clases
{
    public class Validacion : Attribute
    {
        public bool validacion(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
