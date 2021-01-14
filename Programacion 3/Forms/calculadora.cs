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

namespace Programacion_3.Forms
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        Atributo_Calculadora atributo = new Atributo_Calculadora();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = atributo.Sumar(5, 5).ToString();
            textBox2.Text = atributo.Pi(25).ToString();
            textBox3.Text = atributo.Multuplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }
    }
}
