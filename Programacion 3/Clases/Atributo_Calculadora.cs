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

        public Double Sumar(Double cal1, Double cal2)
        {
            return (cal1 + cal2);
        }
        public Double Restar(Double cal1, Double cal2)
        {
            return (cal1 - cal2);
        }
        public Double Multuplicar(Double cal1, Double cal2)
        {
            return (cal1 * cal2);
        }
        public Double Dividir(Double cal1, Double cal2)
        {
            return (cal1 / cal2);
        }

        public Double Pi(Double cal1)
        {
            return (cal1 * pi);
        }

        //////////////////////////////////////////////////////////////////////////////////
        public Double Sumar()
        {
            return (cal1 + cal2);
        }
        public Double Restar()
        {
            return (cal1 - cal2);
        }
        public Double Multuplicar()
        {
            return (cal1 * cal2);
        }
        public Double Dividir()
        {
            return (cal1 / cal2);
        }

        public Double Pi()
        {
            return (cal1 * pi);
        }
    }
}
