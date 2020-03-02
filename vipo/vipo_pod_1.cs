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
    public partial class vipo_pod_1 : Form
    {
        public vipo_pod_1()
        {
            InitializeComponent();
        }

        

        private void vipo_pod_1_Load(object sender, EventArgs e)
        {
           userControl11.Hide();
           /* if (radioButton1.Enabled == true && button9.Enabled == true && button4.Enabled == true)
            {
                userControl11.Show();
                userControl11.BringToFront();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gl = new Form1();
            gl.Show();
            this.Close();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
        }
    }
}
