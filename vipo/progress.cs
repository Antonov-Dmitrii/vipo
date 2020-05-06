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
    public partial class progress : Form
    {
        public progress()
        {
            InitializeComponent();

        }

       

        private void progress_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.vishki". При необходимости она может быть перемещена или удалена.
            this.vishkiTableAdapter.Fill(this.dubakby_VIPODataSet.vishki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.zp_rab". При необходимости она может быть перемещена или удалена.
            this.zp_rabTableAdapter.Fill(this.dubakby_VIPODataSet.zp_rab);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.progress". При необходимости она может быть перемещена или удалена.
            this.progressTableAdapter.Fill(this.dubakby_VIPODataSet.progress);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.dubakby_VIPODataSet.sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.plan_all". При необходимости она может быть перемещена или удалена.
            this.plan_allTableAdapter.Fill(this.dubakby_VIPODataSet.plan_all);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.progress". При необходимости она может быть перемещена или удалена.
            this.progressTableAdapter.Fill(this.dubakby_VIPODataSet.progress);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.plan_all". При необходимости она может быть перемещена или удалена.
            this.plan_allTableAdapter.Fill(this.dubakby_VIPODataSet.plan_all);
            Update();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "SELECT SUM(proc_op) FROM [progress] WHERE [zav_n] = '" + comboBox2.Text + "' AND [complete] =  1";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connectionString))
            {
                DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                label2.Text = (cmd.ExecuteScalar().ToString());
                conn.Close();
            }
            int m1 = int.Parse(label2.Text);
            progressBar1.Value = m1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progress_Update();
        }

        private void progress_Update()
        {
            // тут логика обновления формы
            dataGridView1.Update();
            dataGridView3.Update();
           
        }
    }
}
