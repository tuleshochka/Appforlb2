using MySql.Data.MySqlClient;
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
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=root;" + "pwd=1515;database=database";
            conn.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string query = "use `database`; select a.first_name, a.last_name, b.address, b.city, b.postal_code from individual a left join customer b on a.cust_id = b.cust_id where a.first_name = '"+textBox1.Text+"';";
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
