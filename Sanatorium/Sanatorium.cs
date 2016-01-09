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
    public partial class Sanatorium : Form
    {
        public Sanatorium()
        {
            InitializeComponent();
        }

        private void Sanatorium_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet.sanatoriy". При необходимости она может быть перемещена или удалена.
            this.sanatoriyTableAdapter.Fill(this.sanatoriumDataSet.sanatoriy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
