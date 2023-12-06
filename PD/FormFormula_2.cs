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
    public partial class FormFormula_2 : Form
    {
        public FormFormula_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(FormFormula_2_p.Text);
            double g = Convert.ToDouble(FormFormula_2_g.Text);
            double L = Convert.ToDouble(FormFormula_2_L.Text);
            double Py = Convert.ToDouble(FormFormula_2_Py.Text);
            double P;
            P = p * g * L + Py;
            P = Math.Round(P, 8);

            FormFormula_2_PP.Text = Convert.ToString(P);
        }
    }
}
