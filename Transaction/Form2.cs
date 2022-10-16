using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Transaction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=localhost;uid=root;" + "pwd=1515;database=database";
            conn = new MySqlConnection(); 
            conn.ConnectionString = myConnectionString;
            conn.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            //  string query = "use `database`; " +
            //   "call myProcedure('"+textBox1.Text+"')";
            string query = "use `database`; call myProcedure ('"+textBox1.Text+"')";
            MyDA.SelectCommand = new MySqlCommand(query, conn);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
