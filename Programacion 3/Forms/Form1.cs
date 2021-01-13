using Programacion_3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //[Atributo_Prueba("randy",22)]
        private void Bt_Ejecutar_Click(object sender, EventArgs e)
        {
            // enviar datos a los atrivutos manual y estaticamente
            /*Atributo_Prueba atributo = new Atributo_Prueba();
            atributo.Nombre = "Randy";
            atributo.Edad = 22;
            atributo.resultados();
            MessageBox.Show(atributo.Resultado);*/
            
            // enviar datos a los atributos dinamicamente
            Atributo_Prueba atributo = new Atributo_Prueba();
            atributo.Nombre = Txt_Nombre.Text;
            atributo.Edad = Convert.ToInt32(NUD_Edad.Value.ToString());
            atributo.resultados();
            MessageBox.Show(atributo.Resultado);
        }
    }
}
