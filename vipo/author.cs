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
    public partial class author : Form
    {
        public author()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var log_gl_in = "1";
            var pass_gl_in = "1";
            var log_b = "2";
            var pass_b = "2";
            var log_admin = "3";
            var pass_admin = "3";

            if ((logBox.Text == log_gl_in) && (passBox.Text == pass_gl_in))
                {
                gl_in gl = new gl_in();
                gl.Show();
                this.Close();
                }
            if ((logBox.Text == log_b) && (passBox.Text == pass_b))
                {
                bu_otchet bu = new bu_otchet();
                bu.Show();
                this.Close();
            }
            if ((logBox.Text == log_admin) && (passBox.Text == pass_admin))
                {
                admin admin = new admin();
                admin.Show();
                this.Close();
            }
            else if ((logBox.Text == log_admin) && (passBox.Text == pass_admin) && (logBox.Text == log_gl_in) && (passBox.Text == pass_gl_in) && (logBox.Text == log_b) && (passBox.Text == pass_b))
            {
                MessageBox.Show("Неправильно введен логин или пароль!!!");
            }

        }
    }
}
