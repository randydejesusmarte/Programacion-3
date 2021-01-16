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
    public partial class balon : Form
    {
        public balon()
        {
            InitializeComponent();
            timer1.Start();
        }

        Atributo_balon nalon = new Atributo_balon();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top = nalon.Top1;
            pictureBox1.Left = nalon.Left1;
            nalon.Max_top1 = 1;
            nalon.balon();
        }
    }
}
