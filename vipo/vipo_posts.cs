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
    public partial class vipo_posts : Form
    {
        public vipo_posts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vipo_vishki vishki = new vipo_vishki();
            vishki.Show();
            vishki.label8.Text = button1.Tag.ToString();
            Hide();
            

        }

        private void vipo_posts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.dubakby_VIPODataSet.posts);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vipo_vishki vishki = new vipo_vishki();
            vishki.Show();
            vishki.label8.Text = button5.Tag.ToString();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vipo_vishki vishki = new vipo_vishki();
            vishki.Show();
            vishki.label8.Text = button4.Tag.ToString();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vipo_vishki vishki = new vipo_vishki();
            vishki.Show();
            vishki.label8.Text = button3.Tag.ToString();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vipo_vishki vishki = new vipo_vishki();
            vishki.Show();
            vishki.label8.Text = button2.Tag.ToString();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vipo_vishki vishki = new vipo_vishki();
            vishki.Show();
            vishki.label8.Text = button6.Tag.ToString();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
