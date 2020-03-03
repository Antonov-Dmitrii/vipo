using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vipo
{
   

    public partial class gl_in : Form
    {
        SqlConnection connection;
       // DataSet dataSet;
        //BindingSource bindingSource;
        //DataTable DT;

        public gl_in()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_dmitrii;Password=Qwerty12312");
            dataGridView1.Refresh();
        }

        public void addbutton_Click(object sender, EventArgs e)
        {
            DataRow nRow = dubakby_VIPODataSet.Tables[5].NewRow();
            nRow[0] = textBox1.Text;
            nRow[1] = comboBox1.Text;
            nRow[2] = comboBox2.Text;
            nRow[3] = dateTimePicker1.Text;
            dubakby_VIPODataSet.Tables[5].Rows.Add(nRow);
            plan_agpTableAdapter.Update(dubakby_VIPODataSet.plan_agp);
            dubakby_VIPODataSet.Tables[5].AcceptChanges();
            dataGridView1.Refresh();
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
            this.plan_agpTableAdapter.Fill(this.dubakby_VIPODataSet.plan_agp);
        }
     
     

        private void gl_in_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dubakby_VIPODataSet.plan_all". При необходимости она может быть перемещена или удалена.
            //this.plan_allTableAdapter.Fill(this.dubakby_VIPODataSet.plan_all);
            FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            this.vishkiTableAdapter.Fill(this.dubakby_VIPODataSet.vishki);
            this.plan_agpTableAdapter.Fill(this.dubakby_VIPODataSet.plan_agp);
            dataGridView1.Refresh();
        }

       
        private void progress_button_Click(object sender, EventArgs e)
        {
            progress prog = new progress();
            prog.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plan_agpTableAdapter.Update(dubakby_VIPODataSet);
        }

    }
}
