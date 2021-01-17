using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_3.Clases
{
    public class Atributo_balon : Attribute
    {
        readonly int velocidad = 5;
        readonly int altura = 5;
        private bool borde_y = false;
        private bool borde_x = false;
        int Max_top = 150;
        int Min_top = 319;
        public int Top1 { get; set; }
        public int Left1 { get; set; }
        public int Max_top1 { get => Max_top - 15; set => Max_top = value - 15; }
        public int Min_top1 { get => Min_top; set => Min_top = value; }

        public void balon()
        {
            //rebote
            if (borde_x == true)
            {
                Top1 += altura;
            }
            else
            {
                Top1 -= altura;
            }

            if (Top1 > Max_top)
            {
                if (Top1 >= Min_top)
                {
                    borde_x = false;
                }
            }
            else
            {
                borde_x = true;
            }

            //borde
            if (borde_y == true)
            {
                Left1 -= velocidad;
            }
            else
            {
                Left1 += velocidad;
            }

            if (Left1 <= -16)
            {
                borde_y = false;
            }
            else if (Left1 > 659)
            {
                borde_y = true;
            }
        }
    }
}
