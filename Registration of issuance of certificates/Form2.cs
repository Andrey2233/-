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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f1= new Form3();
            f1.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f1 = new Form7();
            f1.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f1 = new Form8();
            f1.Show();

            this.Hide();
        }
    }
}
