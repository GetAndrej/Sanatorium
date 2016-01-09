using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sanatorium
{
    public partial class SQL : Form
    {
        string constring = "server=localhost;user=root;database=sanatorium;port=3306;password=123456789;";
        public SQL()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {



                MySqlConnection con = new MySqlConnection(constring);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(textBox1.Text, con);

                DataTable dt = new DataTable();
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1 .DataSource = dt;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
