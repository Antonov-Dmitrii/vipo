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
            numbersTableAdapter1.Fill(dubakby_VIPODataSet1.numbers);
            vishkiTableAdapter1.Fill(dubakby_VIPODataSet1.vishki);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            label6.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || string.IsNullOrEmpty(label6.Text))
            {
                MessageBox.Show("Не выбран заводской номер!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                vipo_post1 vipo_post = new vipo_post1();
                vipo_post.Show();
                vipo_post.label4.Text = label7.Text;
                vipo_post.label6.Text = dataGridView1.CurrentCell.EditedFormattedValue.ToString();
                this.Close();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string img = label5.Text;
            dataGridView1.Visible = true;
            pictureBox1.Image = Bitmap.FromFile(img);
            if (string.IsNullOrEmpty(label3.Text))
                numbersBindingSource.Filter = "";
            else
                numbersBindingSource.Filter = string.Format("[id_v] = {0}", label3.Text);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex == 0)
            {
                label6.Text = dataGridView1[0, 0].Value.ToString();
            }
        }
    }
}
