using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
;           connection.ConnectionString = "server=localhost;uid=root;" + "pwd=1515;database=database";
            connection.Open();
            try
            {
                string query = "use `database`; call Anketa('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "', '" + textBox6.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Спасибо за прохождение анкеты");
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

        }
    }
}
