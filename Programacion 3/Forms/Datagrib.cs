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
    public partial class Datagrib : Form
    {
        public Datagrib()
        {
            InitializeComponent();
            ejecutar();
        }

        Atributo_DB DB = new Atributo_DB();
        private void ejecutar()
        {
            DB.FillDB(sql: "select * from login", dataGridView: dataGridView1);
        }
    }
}
