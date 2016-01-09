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
    public partial class Sanatorium2 : Form
    {
        public Sanatorium2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void Sanatorium2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet5.sanatoriy". При необходимости она может быть перемещена или удалена.
            this.sanatoriyTableAdapter.Fill(this.sanatoriumDataSet5.sanatoriy);

        }
    }
}
