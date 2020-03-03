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
    
    public partial class vipo_vishki : Form
    {
        public vipo_vishki()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vipo_post1 vipo_post = new vipo_post1();
            vipo_post.Show();
            vipo_post.label4.Text = comboBox1.Text;
            vipo_post.label6.Text = comboBox2.Text;
            this.Close(); 
        }

        private void vipo_vishki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.plan_all". При необходимости она может быть перемещена или удалена.
            this.plan_allTableAdapter.Fill(this.dubakby_VIPODataSet.plan_all);


        }
    }
}
