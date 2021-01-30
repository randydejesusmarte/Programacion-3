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
        ///valido la caja de texto para saber si se encuentra en blanco
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

        ///creo la variable ts de tipo texbox para el valor bruto
        TextBox ts;
        
        ///entro informacion el la variable ts
        public void parametro(TextBox text)
        {
            ts = text;
            return;
        }
        
        ///variables para obtener el afp
        int afp_porcent=7;
        double afp_result;

        public int Afp_porcent { get => afp_porcent; set => afp_porcent = value; }
        public double Afp_result { get => afp_result; set => afp_result = value; }

        public void Afp()
        {
            //llenar      convertir a double  por  porcentaje a obtener
            Afp_result = double.Parse(ts.Text) * afp_porcent / 100;
            return;
        }

        ///variables para obtener el ars

        int ars_porcent = 3;
        double ars_result;
        public int Ars_porcent { get => ars_porcent; set => ars_porcent = value; }
        public double Ars_result { get => ars_result; set => ars_result = value; }

        public void Ars()
        {
            //llenar     convertir a double   por porcentaje a obtener
            Ars_result = double.Parse(ts.Text) * ars_porcent / 100;
            return;
        }

        /// obtengo el descuento

        double dec_result;
        double ars;
        double afp;
        public double Dec_result { get => dec_result; set => dec_result = value; }

        public void Descuento()
        {
            Afp();//ejecuto el metodo afp
            ars = ars_result;//optengo su resultado

            Ars();//ejecuto el metodo ars
            afp = afp_result;//obtengo su resultado

            dec_result = afp - ars;//resto ambos
            return;
        }
        ///valor neto
        double netos;
        public double Neto { get => netos; set => netos = value; }
        public void T_Neto()
        {
            netos = double.Parse(ts.Text) - dec_result;//resto el descuento con lel valor bruto
            return;
        }

    }
}
