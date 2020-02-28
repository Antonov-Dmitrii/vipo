using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vipo
{
    public partial class bu_otchet : Form
    {
        DataTable dt_bu;
        SqlConnection connection_bu;
        DataSet dataSet_bu;
        BindingSource bindingSource;

        public bu_otchet()
        {
            InitializeComponent();
            connection_bu = new SqlConnection(@"Data Source=93.125.99.108;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312");
            dataSet_bu = new DataSet();
        }

        private void bu_otchet_Load(object sender, EventArgs e)
        {
            Load_table("SELECT * FROM sklad ");
            dataSet_bu.Tables.Clear();
        }
        private void Load_table(string str)
        {
            DataTable dt_bu = new DataTable("sklad");
            connection_bu.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(str, connection_bu);
            dataSet_bu.Tables.Add(dt_bu);
            adapter.Fill(dataSet_bu, "sklad");
            bindingSource = new BindingSource(dataSet_bu, "sklad");
            dataGridView1.DataSource = bindingSource;
            connection_bu.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button5_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Load_table("SELECT * FROM sklad WHERE (id_mat LIKE '%" + textBox2.Text + "%')");
            dataSet_bu.Tables.Clear();
            textBox2.Clear();
        }

        private void Deficit(string str)
        {
            DataTable dt_bu = new DataTable("sklad");
            connection_bu.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(str, connection_bu);
            dataSet_bu.Tables.Add(dt_bu);
            adapter.Fill(dataSet_bu, "sklad");
            bindingSource = new BindingSource(dataSet_bu, "sklad");
            dataGridView1.DataSource = bindingSource;
            connection_bu.Close();
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Deficit("SELECT * FROM sklad WHERE (kol LIKE '0')");
            dataSet_bu.Tables.Clear();
        }
    }
}
