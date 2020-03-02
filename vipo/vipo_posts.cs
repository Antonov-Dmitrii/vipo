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
            vipo_post1 post1 = new vipo_post1();
            post1.Show();
            this.Close();

        }
    }
}
