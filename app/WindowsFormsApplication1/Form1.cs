using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        public void disabled()
        {
            txtNum.Enabled = false;
            btnDot.Enabled = false;
            btnzero.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnPlus.Enabled = false;
            btnMin.Enabled = false;
            btnMul.Enabled = false;
            btnDiv.Enabled = false;
            btnEq.Enabled = false;
            btnClear.Enabled = false;
            btnback.Enabled = false;

        }
        public void enabled()
        {
            txtNum.Enabled = true;
            btnDot.Enabled = true;
            btnzero.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnPlus.Enabled = true;
            btnMin.Enabled = true;
            btnMul.Enabled = true;
            btnDiv.Enabled = true;
            btnEq.Enabled = true;
            btnClear.Enabled = true;
            btnback.Enabled = true;

        }
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text+7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + 9;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + 6;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + 6;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + 3;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + 2;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + 1;
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtNum.Text);
            txtNum.Clear();
            txtNum.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + ".";
        }

        private void btnonoff_Click(object sender, EventArgs e)
        {
            if (btnonoff.Text == "OFF")
            {
                btnonoff.Text = "ON";
                disabled();
            }
            else if (btnonoff.Text == "ON")
            {
                btnonoff.Text = "OFF";
                enabled();
            }
            
        }
        public void compute()
        {
            switch (count)
            {
                case 1: ans = num + float.Parse(txtNum.Text);
                    txtNum.Text = ans.ToString();break;
                case 2: ans = num - float.Parse(txtNum.Text);
                    txtNum.Text = ans.ToString(); break;
                case 3: ans = num * float.Parse(txtNum.Text);
                    txtNum.Text = ans.ToString(); break;
                case 4: ans = num / float.Parse(txtNum.Text);
                    txtNum.Text = ans.ToString(); break;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtNum.Text);
            txtNum.Clear();
            txtNum.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtNum.Text);
            txtNum.Clear();
            txtNum.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtNum.Text);
            txtNum.Clear();
            txtNum.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            int length = txtNum.TextLength - 1;
            string text = txtNum.Text;
            txtNum.Clear();
            for (int i = 0; i < length; i++)
                txtNum.Text = txtNum.Text + text[i];
        }

    }
}
