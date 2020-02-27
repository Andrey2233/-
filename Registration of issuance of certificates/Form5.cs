using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_of_issuance_of_certificates
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();

            this.Hide();
        }

        private void number_of_the_finished_certificateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.number_of_the_finished_certificateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountingCertificatesDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingCertificatesDataSet.Number_of_the_finished_certificate". При необходимости она может быть перемещена или удалена.
            this.number_of_the_finished_certificateTableAdapter.Fill(this.accountingCertificatesDataSet.Number_of_the_finished_certificate);

        }
    }
}
