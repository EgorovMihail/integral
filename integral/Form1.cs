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
                double num1, num2, num3;

                string a = border__a.Text;
                string b = border__b.Text;
                string h = step_in.Text;

                bool AisNum = double.TryParse(a, out num1);
                bool BisNum = double.TryParse(b, out num2);
                bool HisNum = double.TryParse(h, out num3);

                if ((AisNum) && (BisNum) && (HisNum) && (num1 <= num2) && (num3 >= 0.0) && (num1 > 0.0))
                { 
                    DateTime t1 = DateTime.Now;

                    Trap_out.Text = Convert.ToString(Math.Round(p.Trap(num1, num2, num3, x => 2.0 * x - Math.Log(2.0 * x) + 234.0), 3));

                    TimeSpan time = DateTime.Now - t1;
                    eTrap.Text = Convert.ToString(time.TotalSeconds) + " сек";

                    hints.Text = "котик доволен ;)";
                }
                else
                {
                    hints.Text = "Проверьте корректность введенных данных";
                } 
            }
            else
            {
                hints.Text = "Введите параметры интегрирования";
            }
        }


        private void Sims()
        {       
            if ((border__a.Text != "") && (border__b.Text != "") && (iter.Text != ""))
            {
                IntegralMath q = new IntegralMath();
                double num1, num2; int num3;

                string a = border__a.Text;
                string b = border__b.Text;
                string m = iter.Text;

                bool AisNum = double.TryParse(a, out num1);
                bool BisNum = double.TryParse(b, out num2);
                bool MisNum = int.TryParse(m, out num3);

                if ((AisNum) && (BisNum) && (MisNum) && (num1 <= num2) && (num3 > 0) && (num1 > 0.0))
                {
                    DateTime t1 = DateTime.Now;

                    Sims_out.Text = Convert.ToString(Math.Round(q.Sims(num1, num2, num3, x => 2.0 * x - Math.Log(2.0 * x) + 234.0), 3));

                    TimeSpan time = DateTime.Now - t1;
                    eSims.Text = Convert.ToString(time.TotalSeconds) + " сек";

                    hints.Text = "котик доволен ;)";
                }
                else {
                    hints.Text = "Проверьте корректность введенных данных";
                }
            }
            else
            {
                hints.Text = "Введите параметры интегрирования";
            }
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
