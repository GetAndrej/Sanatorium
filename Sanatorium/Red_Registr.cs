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
    public partial class Red_Registr : Form
    {
        public Red_Registr()
        {
            InitializeComponent();
        }

        private void registrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registrationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sanatoriumDataSet5);

        }

        private void Red_Registr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sanatoriumDataSet5.registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.sanatoriumDataSet5.registration);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registrationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sanatoriumDataSet5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
