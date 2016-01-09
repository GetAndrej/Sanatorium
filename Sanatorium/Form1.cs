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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet5.registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.sanatoriumDataSet5.registration);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet5.registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.sanatoriumDataSet5.registration);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vacationers2 vac = new Vacationers2();
            vac.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sanatorium2 san = new Sanatorium2();
            san.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personnel2 per = new Personnel2();
            per.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            sql.Show();
            Hide();
        }
    }
}
