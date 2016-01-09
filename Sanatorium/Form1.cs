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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet.registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.sanatoriumDataSet.registration);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vacationers voc = new Vacationers();
            voc.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sanatorium san = new Sanatorium();
            san.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personnel per = new Personnel();
            per.Show();
            Hide();
        }
    }
}
