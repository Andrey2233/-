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
    public partial class Form7 : Form
    {
        public Form7()
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

        private void the_number_of_the_certificate_of_graduateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.the_number_of_the_certificate_of_graduateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountingCertificatesDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingCertificatesDataSet.The_number_of_the_certificate_of_graduate". При необходимости она может быть перемещена или удалена.
            this.the_number_of_the_certificate_of_graduateTableAdapter.Fill(this.accountingCertificatesDataSet.The_number_of_the_certificate_of_graduate);

        }
    }
}
