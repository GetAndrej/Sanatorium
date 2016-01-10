using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanatorium
{
    public partial class Add_Registration : Form
    {
        public Add_Registration()
        {
            InitializeComponent();
        }

       
        private void Add_Registration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet5.registration". При необходимости она может быть перемещена или удалена.
          //  this.registrationTableAdapter.Fill(this.sanatoriumDataSet5.registration);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                registrationTableAdapter.InsertQuery(Convert.ToInt32(id_registrationTextBox.Text), Convert.ToInt32(id_vacationersTextBox.Text), Convert.ToInt32(id_personalaTextBox.Text), Convert.ToInt32(id_mestaTextBox.Text), today_s_dateDateTimePicker.Value,fromDateTimePicker.Value,tillDateTimePicker.Value,locationTextBox.Text,infoTextBox.Text);
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте на правильность ввода");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
