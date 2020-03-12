using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace vipo
{
    
    public partial class vipo_vishki : Form
    {
        SqlConnection connection;
        DataTable dt;

        public vipo_vishki()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312");
            dataGridView1.Refresh();
        }

        private void vipo_vishki_Load(object sender, EventArgs e)
        {
            numbersTableAdapter.Fill(dubakby_VIPODataSet1.numbers);
            vishkiTableAdapter.Fill(dubakby_VIPODataSet.vishki);
            plan_allTableAdapter.Fill(dubakby_VIPODataSet.plan_all);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vipo_post1 vipo_post = new vipo_post1();
            vipo_post.Show();
            vipo_post.label4.Text = label3.Text;
            this.Close(); 
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label3.Text))
                numbersBindingSource.Filter = "";
            else
                numbersBindingSource.Filter = string.Format("[id_v] = {0}", label3.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComboBox cb = new ComboBox();
            cb.SelectedIndex -= 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComboBox cb = new ComboBox();
            cb.SelectedIndex += 1;
        }
    }
}
