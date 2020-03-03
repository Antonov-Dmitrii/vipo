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
        //работа с БД
/*        private readonly IDataContext _dataContext = new TestDataContext();
        //источник привязки для DGV
        private readonly BindingSource _bsPeople = new BindingSource();
        //объект формирования выборок для DGV
        private readonly FilterDgv _filterDgv = new FilterDgv();*/
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.dubakby_VIPODataSet.sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.dubakby_VIPODataSet.materials);
            Load_table("SELECT * FROM sklad ");
            dataSet_bu.Tables.Clear();
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
