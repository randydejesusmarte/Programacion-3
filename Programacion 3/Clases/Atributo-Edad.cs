using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_3.Clases
{
    public sealed class Atributo_Edad : Attribute
    {
        string nombre;
        int edad;
        string resultado;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Resultado { get => resultado; set => resultado = value; }

        public Atributo_Edad(string n_nombre,int n_edad)
        {
            Nombre = n_nombre;
            Edad = n_edad;
        }

        public Atributo_Edad()
        {
            
        }

        public void resultados()
        {
            resultado = nombre + " tiene " + edad.ToString() + " de edad"; 
        }

    }
}
