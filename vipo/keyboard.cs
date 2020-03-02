using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vipo
{
    public partial class keyboard : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }

        }
        public keyboard()
        {
            InitializeComponent();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Д");
            }
            else
            {
                SendKeys.Send("д");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Э");
            }
            else
            {
                SendKeys.Send("э");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("С");
            }
            else
            {
                SendKeys.Send("с");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Й");
            }
            else
            {
                SendKeys.Send("й");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Ц");
            }
            else
            {
                SendKeys.Send("ц");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("У");
            }
            else
            {
                SendKeys.Send("у");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("К");
            }
            else
            {
                SendKeys.Send("к");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Е");
            }
            else
            {
                SendKeys.Send("е");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Н");
            }
            else
            {
                SendKeys.Send("н");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Г");
            }
            else
            {
                SendKeys.Send("г");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Ш");
            }
            else
            {
                SendKeys.Send("ш");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Щ");
            }
            else
            {
                SendKeys.Send("щ");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("З");
            }
            else
            {
                SendKeys.Send("з");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Х");
            }
            else
            {
                SendKeys.Send("х");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Ъ");
            }
            else
            {
                SendKeys.Send("ъ");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Ф");
            }
            else
            {
                SendKeys.Send("ф");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Ы");
            }
            else
            {
                SendKeys.Send("ы");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("В");
            }
            else
            {
                SendKeys.Send("в");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("А");
            }
            else
            {
                SendKeys.Send("а");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("П");
            }
            else
            {
                SendKeys.Send("п");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Р");
            }
            else
            {
                SendKeys.Send("р");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("О");
            }
            else
            {
                SendKeys.Send("о");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Л");
            }
            else
            {
                SendKeys.Send("л");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Ж");
            }
            else
            {
                SendKeys.Send("ж");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Я");
            }
            else
            {
                SendKeys.Send("я");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Ч");
            }
            else
            {
                SendKeys.Send("ч");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("М");
            }
            else
            {
                SendKeys.Send("м");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("И");
            }
            else
            {
                SendKeys.Send("и");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Т");
            }
            else
            {
                SendKeys.Send("т");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Ь");
            }
            else
            {
                SendKeys.Send("ь");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Б");
            }
            else
            {
                SendKeys.Send("б");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("Ю");
            }
            else
            {
                SendKeys.Send("ю");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("1");
            }
            else
            {
                SendKeys.Send("1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("2");
            }
            else
            {
                SendKeys.Send("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("3");
            }
            else
            {
                SendKeys.Send("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("4");
            }
            else
            {
                SendKeys.Send("4");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("5");
            }
            else
            {
                SendKeys.Send("5");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("6");
            }
            else
            {
                SendKeys.Send("6");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("7");
            }
            else
            {
                SendKeys.Send("7");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("8");
            }
            else
            {
                SendKeys.Send("8");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("9");
            }
            else
            {
                SendKeys.Send("9");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("0");
            }
            else
            {
                SendKeys.Send("0");
            }
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
