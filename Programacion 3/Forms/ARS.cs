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
        ARSc ARc = new ARSc();
        private void button1_Click(object sender, EventArgs e)
        {
            if(new Validacion().validacion(textBox1))
            {
                ARc.parametro(textBox1);

                ARc.Afp();
                textBox2.Text = ARc.Afp_result.ToString();

                ARc.Ars();
                textBox3.Text = ARc.Ars_result.ToString();

                ARc.Descuento();
                textBox4.Text = ARc.Dec_result.ToString();

                ARc.T_Neto();
                textBox5.Text = ARc.Neto.ToString();
            }
            else
            {
                MessageBox.Show("falta el total bruto","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
