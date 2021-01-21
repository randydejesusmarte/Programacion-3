using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_3.Clases
{
    public class ARSc
    {
        public bool Validacion(TextBox text)
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

        /// 

        int afp_porcent=7;
        double afp_result;
        TextBox ts;

        public int Afp_porcent { get => afp_porcent; set => afp_porcent = value; }
        public double Afp_result { get => afp_result; set => afp_result = value; }

        public void Afp(TextBox text)
        {
            ts = text;
            Afp_result = double.Parse(text.Text) * afp_porcent / 100;
            return;
        }

        /// 

        int ars_porcent = 3;
        double ars_result;
        public int Ars_porcent { get => ars_porcent; set => ars_porcent = value; }
        public double Ars_result { get => ars_result; set => ars_result = value; }

        public void Ars(TextBox text)
        {
            ts = text;
            Ars_result = double.Parse(text.Text) * ars_porcent / 100;
            return;
        }

        /// 

        double dec_result;
        double ars;
        double afp;
        public double Dec_result { get => dec_result; set => dec_result = value; }

        public void Descuento()
        {
            Afp(ts);
            ars = ars_result;

            Ars(ts);
            afp = afp_result;

            dec_result = afp - ars;
            return;
        }

        double netos;
        public double Neto { get => netos; set => netos = value; }
        public void T_Neto()
        {
            netos = double.Parse(ts.Text) - dec_result;
            return;
        }

    }
}
