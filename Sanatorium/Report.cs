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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSetR1.registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.sanatoriumDataSetR1.registration);

            this.reportViewer1.RefreshReport();
        }
    }
}
