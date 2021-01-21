using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programacion_3.Clases;

namespace Programacion_3.Forms
{
    public partial class ARS : Form
    {
        public ARS()
        {
            InitializeComponent();
        }
        ARSc ARSc = new ARSc();
        private void button1_Click(object sender, EventArgs e)
        {
            if(new Validacion().validacion(textBox1))
            {
                ARSc.Afp(textBox1);
                textBox2.Text = ARSc.Afp_result.ToString();

                ARSc.Ars(textBox1);
                textBox3.Text = ARSc.Ars_result.ToString();

                ARSc.Descuento();
                textBox4.Text = ARSc.Dec_result.ToString();

                ARSc.T_Neto();
                textBox5.Text = ARSc.Neto.ToString();
            }
        }
    }
}
