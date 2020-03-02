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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            author aut = new author();
            aut.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           bank bank_1= new bank();
           bank_1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           vipo_vishki vipo_1 = new vipo_vishki();
            vipo_1.Show();
            
        }
    }
}
