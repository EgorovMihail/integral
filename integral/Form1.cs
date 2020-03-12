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

        private void Trap()
        {
            if ((border__a.Text != "") && (border__b.Text != "") && (step_in.Text != ""))
            {
                IntegralMath p = new IntegralMath();

                double a = Convert.ToDouble(border__a.Text);
                double b = Convert.ToDouble(border__b.Text);
                double h = Convert.ToDouble(step_in.Text);  

                DateTime t1 = DateTime.Now;

                Trap_out.Text = Convert.ToString(Math.Round(p.Trap(a, b, h, x => 2 * x - Math.Log(2 * x) + 234), 3));

                TimeSpan time = DateTime.Now - t1;
                eTrap.Text = Convert.ToString(time.TotalSeconds) + " сек";

                hints.Text = "котик доволен ;)";
            }
            else
            {
                hints.Text = "введите параметры интегрирования";
            }
        }


        private void Sims()
        {       
            if ((border__a.Text != "") && (border__b.Text != "") && (iter.Text != ""))
            {
                IntegralMath q = new IntegralMath();

                double a = Convert.ToDouble(border__a.Text);
                double b = Convert.ToDouble(border__b.Text);
                int m = Convert.ToInt32(iter.Text);

                DateTime t1 = DateTime.Now;

                Sims_out.Text = Convert.ToString(Math.Round(q.Sims(a, b, m, x => 2 * x - Math.Log(2 * x) + 234), 3));

                TimeSpan time = DateTime.Now - t1;
                eSims.Text = Convert.ToString(time.TotalSeconds) + " сек";

                hints.Text = "котик доволен ;)";
            }
            else
            {
                hints.Text = "введите параметры интегрирования";
            }
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
        }

        private void border__b_TextChanged(object sender, EventArgs e)
        {
            Trap();
            Sims();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            Trap();
        }

        private void Sims_out_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iter_TextChanged(object sender, EventArgs e)
        {
            Sims();
        }

        private void border__a_TextChanged_1(object sender, EventArgs e)
        {
            Trap();
            Sims();
        }
    }
}
