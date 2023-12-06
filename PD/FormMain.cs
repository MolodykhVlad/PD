using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formula1Form;

namespace PD
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFormula_1 formformula_1 = new FormFormula_1();
            formformula_1.Show();
        }

        private void Formula2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFormula_2 formformula_2 = new FormFormula_2();
            formformula_2.Show();

        }

        private void Formula3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFormula_3 formformula_3 = new FormFormula_3();
            formformula_3.Show();
        }

        private void Formula4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFormula_4 formformula_4 = new FormFormula_4();
            formformula_4.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormFormula_5 formformula_5 = new FormFormula_5();
            formformula_5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFormula_6 formformula_6 = new FormFormula_6();
            formformula_6.Show();
        }
    }
}
