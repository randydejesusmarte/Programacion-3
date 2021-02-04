using Programacion_3.Clases;
using Programacion_3.Forms;
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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Edad().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new calculadora().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new balon().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ARS().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Datagrib().ShowDialog();
        }
    }
}
