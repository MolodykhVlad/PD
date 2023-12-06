using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PD;

namespace Formula1Form
{
    public partial class FormFormula_1 : Form
    {
        public FormFormula_1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(FormFormula_1_p.Text);
            double g = Convert.ToDouble(FormFormula_1_g.Text);
            double H = Convert.ToDouble(FormFormula_1_H.Text);
            double P;
            P = p * g * H;

            FormFormula_1_PP.Text = Convert.ToString(P);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMai
        }
    }
}
