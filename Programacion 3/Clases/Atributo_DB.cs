using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Programacion_3.Clases
{
    public class Atributo_DB : Attribute
    {
        SqlConnection connection = new SqlConnection("Data Source = RANDY\\SQLEXPRESS;  Initial Catalog = hidra; Integrated Security = True;");
        public void FillDB(string sql, DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                sqlData.SelectCommand = new SqlCommand(sql, connection);
                sqlData.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                connection.Close();
            }
        }

        /*
         public void combobox(ComboBox comboBox,string str,string codigo,string descripcion)
         {
             DataTable table = new DataTable();
             SqlDataAdapter adapter = new SqlDataAdapter();
             adapter.SelectCommand = new SqlCommand(str, connection);
             adapter.Fill(table);
             comboBox.DataSource = table;
             comboBox.DisplayMember = descripcion;
             comboBox.ValueMember = codigo;
         }*/


    }
}
