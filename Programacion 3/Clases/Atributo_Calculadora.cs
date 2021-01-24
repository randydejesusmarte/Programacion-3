using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_3.Clases
{
    public class Atributo_Calculadora : Attribute
    {
        //////////////////////////////////////////////////////////////////////////////////
        private const double pi = 3.14;
        private double cal1 = 0;
        private double cal2 = 0;
        //////////////////////////////////////////////////////////////////////////////////

        public double Sumar(double cal1, double cal2)
        {
            return (cal1 + cal2);
        }
        public double Restar(double cal1, double cal2)
        {
            return (cal1 - cal2);
        }
        public double Multuplicar(double cal1, double cal2)
        {
            return (cal1 * cal2);
        }
        public double Dividir(double cal1, double cal2)
        {
            return (cal1 / cal2);
        }

        public double Pi(double cal1)
        {
            return (cal1 * pi);
        }

        //////////////////////////////////////////////////////////////////////////////////
        public double Sumar()
        {
            return (cal1 + cal2);
        }
        public double Restar()
        {
            return (cal1 - cal2);
        }
        public double Multuplicar()
        {
            return (cal1 * cal2);
        }
        public double Dividir()
        {
            return (cal1 / cal2);
        }

        public double Pi()
        {
            return (cal1 * pi);
        }
    }
}
