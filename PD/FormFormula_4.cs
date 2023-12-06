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
    public partial class FormFormula_4 : Form
    {
        public FormFormula_4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonResult_form_1_Click(object sender, EventArgs e)
        {
            double ro = Convert.ToDouble(FormFormula_4_ro.Text);
            double L = Convert.ToDouble(FormFormula_4_L.Text);
            double z = Convert.ToDouble(FormFormula_4_z.Text);
            double T = Convert.ToDouble(FormFormula_4_T.Text);
            double s;
            s = Math.Pow(0.03415, ((ro * L) / (z * T)));
            s = Math.Round(s, 10);
            double p = Convert.ToDouble(FormFormula_4_p.Text);
            double exp = Convert.ToDouble(FormFormula_4_exp.Text);
            FormFormula_4_s.Text = Convert.ToString(s);
            double P;
            P = p * Math.Pow(exp, s);
            FormFormula_4_PP.Text = Convert.ToString(P);

        }

        private void FormFormula_4_e_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
