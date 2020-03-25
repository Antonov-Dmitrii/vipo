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

        //  SELECT [id_op],[num_op],[op_name],[kol_rab],[time_norm] FROM [progress] WHERE [zav_n] = '" + label.. + "'  AND [id_v] = '"+ label... + "' AND [id_post] = '" + label... + "' AND [complete] = '" + label... + "' 


        //label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds.Tables["QUALITY"], "op_name"));
/*
         SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db3;Integrated Security=True");
         conn.Open();
         SqlCommand cmd = new SqlCommand("select count (number) from t2 where number=@number", conn); 
         cmd.Parameters.AddWithValue("@number", label1.Text); 
         label5.Text=(cmd.ExecuteScalar().ToString()); 
         conn.Close();
*/
       
        
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
                vipo_post.label14.Text = label8.Text;
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
            pictureBox2.Image = Image.FromFile(img);
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
