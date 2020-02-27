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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void the_number_of_the_certificateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingCertificatesDataSet1.The_number_of_the_certificate". При необходимости она может быть перемещена или удалена.
            this.the_number_of_the_certificateTableAdapter.Fill(this.accountingCertificatesDataSet1.The_number_of_the_certificate);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingCertificatesDataSet.The_number_of_the_certificate". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingCertificatesDataSet.The_number_of_the_certificate". При необходимости она может быть перемещена или удалена.

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

        private void номер_выпускникаLabel_Click(object sender, EventArgs e)
        {

        }

        private void номер_сотрудникаLabel_Click(object sender, EventArgs e)
        {

        }

        private void the_number_of_the_certificateBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.the_number_of_the_certificateBindingSource.EndEdit();

        }

        private void номер_выпускникаComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void the_number_of_the_certificateBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.the_number_of_the_certificateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountingCertificatesDataSet1);

        }

        private void номер_выпускникаLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
