using System;
using System.Windows.Forms;
using System.Threading;

namespace vipo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
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
            vipo_posts vipo_Posts = new vipo_posts();
            vipo_Posts.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
