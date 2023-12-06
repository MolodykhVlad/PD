using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD
{
    public partial class FormFormula_3 : Form
    {
        public FormFormula_3()
        {
            InitializeComponent();
        }

        private void buttonResult_form_1_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(FormFormula_3_p.Text);
            double H = Convert.ToDouble(FormFormula_3_H.Text);
            double C = Convert.ToDouble(FormFormula_3_C.Text);
            double P;
            P = (H * p) / C;
            P = Math.Round(P, 8);
            FormFormula_3_PP.Text = Convert.ToString(P);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormFormula_3_C_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormFormula_3_H_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormFormula_3_p_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormFormula_3_PP_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
