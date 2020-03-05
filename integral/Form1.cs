using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integral
{
    public partial class integral__Form : Form
    {
        public integral__Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void integral__Form_Load(object sender, EventArgs e)
        {

        }

        private void SimsT_out_Click(object sender, EventArgs e)
        {

        }

        private void border__a_TextChanged(object sender, EventArgs e)
        {
            if ((border__b.Text != "") && (border__a.Text != ""))
            {
                Task p = new Task();

                double a = Convert.ToDouble(border__a.Text);
                double b = Convert.ToDouble(border__b.Text);
                double h = 0.1;

                Trap_out.Text = Convert.ToString(Math.Round(p.Trap(a, b, h), 3));

                hints.Text = "котик доволен ;)";
            }
            else
            {
                hints.Text = "введите параметры интегрирования";
            }
        }

        private void border__b_TextChanged(object sender, EventArgs e)
        {
            if ((border__a.Text != "") && (border__b.Text != ""))
            {
                Task p = new Task();

                double a = Convert.ToDouble(border__a.Text);
                double b = Convert.ToDouble(border__b.Text);
                double h = 0.1;

                Trap_out.Text = Convert.ToString(Math.Round(p.Trap(a, b, h), 3));

                hints.Text = "котик доволен ;)";
            }
            else
            {
                hints.Text = "Введите параметры интегрирования";
            }
        }
    }
}
