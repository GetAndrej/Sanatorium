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
    public partial class Add_Vacation : Form
    {
        public Add_Vacation()
        {
            InitializeComponent();
        }

       

        private void Add_Vacation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet5.vacationers". При необходимости она может быть перемещена или удалена.
          //  this.vacationersTableAdapter.Fill(this.sanatoriumDataSet5.vacationers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            vacationersTableAdapter.InsertQuery2(Convert.ToInt32(id_vacationersTextBox.Text), name_vocTextBox.Text, Convert.ToInt32(ageTextBox.Text), telephoneTextBox.Text, emailTextBox.Text, home_addressTextBox.Text);
            Hide();
        }
            catch (Exception)
            {
                MessageBox.Show("Check for proper input");
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
