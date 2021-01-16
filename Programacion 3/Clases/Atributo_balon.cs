using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_3.Clases
{
    public class Atributo_balon : Attribute
    {
            int velocidad = 5;
            int altura = 10;

            bool borde_y = false;

            bool borde_x = false;


            int Max_top = 150;
            int Min_top = 319;

            /// <summary>
            /// variable de movimiento
            /// </summary>

            int Top;
            int Left;

            public int Top1 { get => Top; set => Top = value; }
            public int Left1 { get => Left; set => Left = value; }

            public int Max_top1 { get => Max_top - 15; set => Max_top = value - 15; }
            public int Min_top1 { get => Min_top; set => Min_top = value; }

            public void balon()
            {
                //rebote
                if (borde_x == true)
                {
                    Top += altura;
                }
                else
                {
                    Top -= altura;
                }

                if (Top <= Max_top)
                {
                    borde_x = true;
                }
                else if (Top >= Min_top)
                {
                    borde_x = false;
                }

                //borde
                if (borde_y == true)
                {
                    Left -= velocidad;
                }
                else
                {
                    Left += velocidad;
                }

                if (Left <= -16)
                {
                    borde_y = false;
                }
                else if (Left > 659)
                {
                    borde_y = true;
                }
            }
    }
}
