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
    public partial class Vacationers2 : Form
    {
        public Vacationers2()
        {
            InitializeComponent();
        }

        private void Vacationers2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet5.vacationers". При необходимости она может быть перемещена или удалена.
            this.vacationersTableAdapter.Fill(this.sanatoriumDataSet5.vacationers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Vacation vac = new Add_Vacation();
            vac.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить удаление?", "Удаление данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    vacationersTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите пожалуйста полностью строку");
                }
                vacationersTableAdapter.Fill(sanatoriumDataSet5.vacationers);
                sanatoriumDataSet5.AcceptChanges();


            }
        }
    }
}
