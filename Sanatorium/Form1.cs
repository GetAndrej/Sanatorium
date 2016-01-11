using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sanatorium
{
    public partial class Form1 : Form
    {
        string constring = "server=localhost;user=root;database=sanatorium;port=3306;password=123456789;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSetR.registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.sanatoriumDataSetR.registration);
                    
           
        }

      
                     
        private void button10_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить удаление?", "Удаление данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    registrationTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите пожалуйста полностью строку");
                }
                registrationTableAdapter.Fill(sanatoriumDataSetR.registration);
                sanatoriumDataSetR.AcceptChanges();


            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Red_Registr red = new Red_Registr();
            red.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Add_Registration reg = new Add_Registration();
            reg.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Vacationers2 vac = new Vacationers2();
            vac.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Sanatorium2 san = new Sanatorium2();
            san.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Personnel2 per = new Personnel2();
            per.Show();
            Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            sql.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // поиск по vacationers и по personal 
            cmd.CommandText = "select * from registration where id_vacationers like('%" + textBox1.Text + "%') or id_personala like('%" + textBox1.Text + "%')";
            //поиск только по vacationers
            cmd.CommandText = "select * from registration where id_vacationers like('%" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Sort(dataGridView1.Columns[Convert.ToInt32(textBox2.Text)], 0);
            }
            catch
            {
                MessageBox.Show("Ведите от 1 до 9!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(constring);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select registration.* from registration, vacationers where (vacationers.Id_vacationers = registration.id_vacationers) and vacationers.age<20";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("нет!(");
              
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(constring);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from registration where info > (select avg(info) from registration)";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("нет!(");

            }
        }
    }
}
