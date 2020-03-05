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
            //////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "INSERT INTO progress (zav_n, id_v, id_post ,id_op, num_op , op_name ,kol_rab , time_norm , f_time , otkl, proc_op, complete) SELECT @zav_n, id_v, id_post ,id_op, num_op , op_name ,kol_rab , time_norm ,0 ,0 , proc_op, 0 FROM op_norm WHERE id_v = 1201 ";          
            //string queryString = "TRUNCATE TABLE progress";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Parameters.Add("@zav_n", SqlDbType.NVarChar).Value = textBox1.Text;
                  //  command.Parameters.AddWithValue("@id_v", (string)comboBox1.SelectedValue);
                   // command.Parameters.AddWithValue("@zav_n", (string)textBox1.Text);
                    command.CommandText = queryString;

                    try
                    {   
                        connection.Open();
                       
                       command.ExecuteNonQuery();
                        MessageBox.Show("План добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления" );
                        throw;
                    }
                }
            }
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
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "TRUNCATE TABLE progress";

            //string queryString = "TRUNCATE TABLE progress";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = queryString;

                    try
                    {
                        connection.Open();
                        Int32 rowsAffected = command.ExecuteNonQuery();
                        // command.ExecuteNonQuery();
                        MessageBox.Show("План добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления");
                        throw;
                    }
                }
            }
            //  progress prog = new progress();
            //prog.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=dubakby.w12.hoster.by;Initial Catalog=dubakby_VIPO;Persist Security Info=True;User ID=dubakby_Dubak;Password=Qwerty12312";
            string queryString = "INSERT INTO plan_all (id_v, zav_n, volt, data_pl, data_v, complete) SELECT id_v, zav_n, volt, data_pl, 0, 0 FROM plan_agp;TRUNCATE TABLE plan_agp";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = queryString;

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("План добавлен");
                        this.plan_agpTableAdapter.Fill(this.dubakby_VIPODataSet.plan_agp);
                        dataGridView1.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления");
                        throw;
                    }
                }
            }
        }

       
    }
}
