using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_giaiphuongtrinhbat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void akba_Scroll(object sender, EventArgs e)
        {
            txta.Text = akba.Value.ToString();
        }

        private void akbb_Scroll(object sender, EventArgs e)
        {
            txtb.Text = akbb.Value.ToString();
        }

        private void akbc_Scroll(object sender, EventArgs e)
        {
            txtc.Text = akbc.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = Convert.ToInt32(txtc.Text);
            double delta, x1, x2;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c != 0)
                    {
                        lblkq.Text = "phương trình vo6 nghiệm";
                    }
                    else
                    {
                        lblkq.Text = "phương trình có vô số nghiệm";
                    }
                }
                else
                {

                    lblkq.Text = "phương trình có nghiệm x1=x2" + ((-c) / b).ToString();
                }
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lblkq.Text = "phương trình vô nghiệm";
                }
                else if (delta == 0)
                {

                    lblkq.Text = "phương trình có nghiệm kép" + ((-b) / (2 * a)).ToString();

                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2=(-b -Math.Sqrt(delta)) / (2 * a);
                    lblkq.Text = "phương trình có 2 nghiệm phân biêt\n" + "x1=" + x1 + "\nx2 =" + x2;
                   
                }
            }
        }
    }
}   
