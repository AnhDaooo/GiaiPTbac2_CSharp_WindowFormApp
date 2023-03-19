using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTapp
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btGPT_Click(object sender, EventArgs e)
        {
            float a, b, c, delta, x1, x2;

            // lấy hệ số user đã nhập từ hộp
            a = float.Parse(txtHeSoA.Text);
            b = float.Parse(txtHeSoB.Text);
            c = float.Parse(txtHeSoC.Text);

            delta = b * b - 4 * a * c;

            if(delta < 0)
            {
                txtKetQua.Text = "phương trình vô nghiệm";
            }
            else if(delta == 0)
            {
                x1 = -b / (2 * a);
                txtKetQua.Text = "phương trình có nghiệm kép x = " + x1.ToString();
            }
            else
            {
                x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);

                txtKetQua.Text = "phương trình có 2 nghiệm phân biệt: " 
                                    + "\r\n x1 = " + x1.ToString()
                                    + "\r\n x2 = " + x2.ToString();
            }
        }
    }
}
