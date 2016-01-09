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
    public partial class Vacationers : Form
    {
        public Vacationers()
        {
            InitializeComponent();
        }

        private void Vacationers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet.vacationers". При необходимости она может быть перемещена или удалена.
            this.vacationersTableAdapter.Fill(this.sanatoriumDataSet.vacationers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
